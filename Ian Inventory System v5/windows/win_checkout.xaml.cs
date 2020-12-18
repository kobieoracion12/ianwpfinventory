using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_checkout : Window
    {
        Database conn = new Database();
        Checkout checkout = new Checkout();
        StocksCheck stocksck = new StocksCheck();

        public win_checkout()
        {
            InitializeComponent();
            entrySearch.Focus();
            accNumberGen();
        }

        public string Value { get; set; }
        public win_checkout(string value)
        {
            this.Value = value; // Store the passed value to the variable value
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            window_cashButton.myCash =  cashAmount.Text;
        }

        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            checkout.payMethod = "Cash";
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }

        // Account Number Generator
        public string accNumberGen()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 13; i++)
            {
                r += random.Next(0, 9).ToString();
                string query = "SELECT COUNT(1) FROM datasalesinventory WHERE orderNo = @order";
                conn.query(query);
                try
                {
                    conn.Open();
                    conn.bind("@order", r);
                    conn.cmd().Prepare();
                    var check = conn.execute();
                    if (check == 1)
                    {
                        accNumberGen();
                    }
                    else
                    {
                        orderNo.Text = Convert.ToString(r);
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            return r;
        }

        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            checkout.paid = Convert.ToInt32(msg);
            cashAmount.Text = Convert.ToString(checkout.paid);
            pay_paid.Text = Convert.ToString(checkout.paid);

            checkout.due = checkout.paid - checkout.total;
            pay_due.Text = Convert.ToString(checkout.due);

            try
            {
                string payment = "INSERT INTO sales_preview (payment_method, payment_vat, payment_total, payment_paid, payment_due, payment_date) VALUES (@method, @vat, @total, @paid, @due, @date)";
                conn.query(payment);  // Command DB
                conn.Open();
                conn.bind("@method", checkout.payMethod);
                conn.bind("@vat", checkout.tax);
                conn.bind("@total", checkout.total);
                conn.bind("@paid", checkout.paid);
                conn.bind("@due", checkout.due);
                conn.bind("@date", DateTime.Now);
                conn.cmd().Prepare();

                var cff = conn.execute();
                if (cff == 1)
                {
                    MessageBox.Show("Success!");
                    entrySearch.IsReadOnly = true;
                    cashButton.IsEnabled = false;
                    voidEntry.IsEnabled = false;
                    endSale.IsEnabled = true;
                }
                conn.Close(); // Close Connection
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                clearPartial();
            }
        }

        // Clear Textboxes Only
        public void clearPartial()
        {
            entrySearch.Focus();
            entrySearch.Clear();
             coItem.Clear();
             coBrand.Clear();
             coSRP.Clear();
             coRP.Clear();
             coSubtotal.Clear();
             coStocks.Clear();
             coRemStocks.Clear();
            coCurrent.Clear();
            coCurrentNew.Clear();
        }

        // Clear All
        public void clearAll()
        {
            entrySearch.Focus();
            listViewinVoice.Items.Clear();
            entrySearch.Clear();
            coItem.Clear();
            coBrand.Clear();
            coSRP.Clear();
            coRP.Clear();
            coSubtotal.Clear();
            coStocks.Clear();
            coRemStocks.Clear();
            coCurrent.Clear();
            coCurrentNew.Clear();

            pay_discount.Text = "0";
            pay_subtotal.Text = "₱ 0.00";
            pay_total.Text = "₱ 0.00";
            pay_paid.Text = "₱ 0.00";
            pay_due.Text = "₱ 0.00";

            checkout.rmstocks = 0;
            checkout.subtotal = 0;
            checkout.vat = 0;
            checkout.total = 0;
            checkout.paid = 0;
            checkout.due = 0;
             cashAmount.Text = "₱ 0.00";

            checkout.total = 0;

            cashButton.IsEnabled = false;
            voidEntry.IsEnabled = false;
            endSale.IsEnabled = false;
            entrySearch.IsReadOnly = false;
        }

        // Barcode Search Function
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                conn.Close();
                string search = entrySearch.Text;
                string query = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodBought FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(query); //CMD 
                conn.Open();
                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    coItem.Text = dr.GetValue(0).ToString();
                    coBrand.Text = dr.GetValue(1).ToString();
                    coStocks.Text = dr.GetValue(2).ToString();
                    coSRP.Text = dr.GetValue(3).ToString();
                    coRP.Text = dr.GetValue(4).ToString();
                    coCurrent.Text = dr.GetValue(5).ToString();

                    stocksck.productQty = Convert.ToInt32(dr.GetValue(2));
                    int checkQty = Convert.ToInt32(stocksck.productQty);
                    if (checkQty >= 1)
                    {
                        // Closes the reader so the next query will work            
                        dr.Close();
                        dr.Dispose(); // Dispose
                        Compute();

                    }
                    else
                    {
                        MessageBox.Show("Item Out of Stock!");
                        clearPartial();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Item not Found");
                    clearPartial();
                }

            }

        }

        // Computes Recieved Data from Barcode
        public void Compute()
        {
            // Math Goes Here....
            if (coRP.Text.Length > 0)
            {
                cashButton.IsEnabled = true;
                voidEntry.IsEnabled = true;

                int rp = Convert.ToInt32(coRP.Text);
                int qty = Convert.ToInt32(coQty.Text);
                int cur = Convert.ToInt32(coCurrent.Text);
                int stk = Convert.ToInt32(coStocks.Text);
                int sub = rp * qty;

                checkout.rmstocks = stk - qty;
                checkout.total += checkout.tax + sub;
                checkout.bought = cur + qty;

                coRemStocks.Text = Convert.ToString(checkout.rmstocks);
                coSubtotal.Text = Convert.ToString(sub);
                pay_subtotal.Text = Convert.ToString(checkout.subtotal + sub);
                pay_total.Text = Convert.ToString(checkout.total);
                coCurrentNew.Text = Convert.ToString(checkout.bought);

                // Adds the data to the datasalesinventory
                if (coSubtotal.Text.Length > 0)
                {
                    try
                    {
                        string query2 = "INSERT INTO datasalesinventory (orderNo, salesNo, salesItem, salesBrand, salesSRP, salesRP, salesQty, salesTotal, salesDate) VALUES (@no, @a, @b, @c, @d, @e, @f, @g, @h)";
                        conn.query(query2);

                        conn.bind("@no", orderNo.Text);
                        conn.bind("@a", entrySearch.Text);
                        conn.bind("@b", coItem.Text);
                        conn.bind("@c", coBrand.Text);
                        conn.bind("@d", coSRP.Text);
                        conn.bind("@e", coRP.Text);
                        conn.bind("@f", coQty.Text);
                        conn.bind("@g", coSubtotal.Text);
                        conn.bind("@h", DateTime.Now);
                        conn.cmd().Prepare();
                        var cf = conn.execute();
                        if (cf == 1)
                        {
                            try
                            {
                                //conn.Open(); // Remove cause of Already Connection
                                string ranking = "UPDATE datainventory SET prodBought = @bought WHERE prodNo = @itemNo";
                                conn.query(ranking);

                                conn.bind("@itemNo", entrySearch.Text);
                                conn.bind("@bought", coCurrentNew.Text);

                                var check = conn.execute();
                                if (check == 1)
                                {
                                    string remaining = "UPDATE datainventory SET prodQty = @rm WHERE prodNo = @ItemNo";
                                    conn.query(remaining);

                                    try
                                    {
                                        conn.bind("@rm", coRemStocks.Text);
                                        conn.bind("@itemNo", entrySearch.Text);
                                        conn.cmd().Prepare();
                                        conn.execute();
                                    }
                                    catch (Exception x)
                                    {
                                        MessageBox.Show(x.Message);
                                    }
                                    conn.Close();
                                }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }

                            listViewinVoice.Items.Add(new invoiceClass.gg { salesItem = coItem.Text, salesRP = rp.ToString(), salesQty = qty.ToString(), salesTotal = sub.ToString()});
                            clearPartial();
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                        clearPartial();
                    }
                }
            }
        }

        // Void Button
        private void voidEntry_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Are you sure you want to void?", "Void", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }

        //End Sales Button
        private void endSale_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Are you sure you want to end transaction?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }
    }
}
