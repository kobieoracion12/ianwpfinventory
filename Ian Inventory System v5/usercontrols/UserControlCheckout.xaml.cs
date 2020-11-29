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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlCheckout : UserControl
    {
        Database conn = new Database();
        StocksCheck stocksck = new StocksCheck();

        public int rmstocks = 0;
        public int subtotal = 0;
        public int vat = 0;
        public int total = 0;
        public int due = 0;
        public int paid = 0;
        public int tax = 0;
        public int bought = 0;
        public string payMethod = "";

        public UserControlCheckout()
        {
            InitializeComponent();
            entrySearch.Focus();
        }

        public UserControlCheckout(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        // Create a variable to store the value
        public string Value { get; set; }

        // When Checkout loads
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            window_cashButton.myCash = cashAmount.Text;
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            payMethod = "Cash";
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }

        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            paid = Convert.ToInt32(msg);
            cashAmount.Text = Convert.ToString(paid);
            pay_paid.Text = Convert.ToString(paid);

            due = paid - total;
            pay_due.Text = Convert.ToString(due);

            try
            {
                string payment = "INSERT INTO sales_preview (payment_method, payment_vat, payment_total, payment_paid, payment_due, payment_date) VALUES (@method, @vat, @total, @paid, @due, @date)";
                conn.query(payment);  // Command DB
                conn.Open();
                conn.bind("@method", payMethod);
                conn.bind("@vat", tax);
                conn.bind("@total", total);
                conn.bind("@paid", paid);
                conn.bind("@due", due);
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

            rmstocks = 0;
            subtotal = 0;
            vat = 0;
            total = 0;
            paid = 0;
            due = 0;
            cashAmount.Text = "₱ 0.00";

            total = 0;

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

                rmstocks = stk - qty;
                total += vat + sub;
                bought = cur + qty;

                coRemStocks.Text = Convert.ToString(rmstocks);
                coSubtotal.Text = Convert.ToString(sub);
                pay_subtotal.Text = Convert.ToString(subtotal + sub);
                pay_total.Text = Convert.ToString(total);
                coCurrentNew.Text = Convert.ToString(bought);

                // Adds the data to the datasalesinventory
                if (coSubtotal.Text.Length > 0)
                {
                    try
                    {
                        string query2 = "INSERT INTO datasalesinventory (salesNo, salesItem, salesBrand, salesSRP, salesRP, salesQty, salesTotal, salesDate) VALUES (@a, @b, @c, @d, @e, @f, @g, @h)";
                        conn.query(query2);

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

                            listViewinVoice.Items.Add(new invoiceClass.gg { salesNo = entrySearch.Text, salesItem = coItem.Text, salesRP = rp.ToString(), salesQty = qty.ToString(), salesTotal = sub.ToString(), salesDate = DateTime.Now });
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Are you sure you want to void?", "Void", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }

        // End Sale Button
        private void endSale_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Are you sure you want to end transaction?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }

        // Keyboard Shortcuts
        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            // CashButton Shortcut
            if (cashButton.IsEnabled == true) {
                if (e.Key == Key.F1)
                {   
                    payMethod = "Cash";
                    window_cashButton cf = new window_cashButton();
                    cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
                    cf.ShowDialog();
                }
            }

            // End Sale Shortcut
            if (endSale.IsEnabled == true)
            {
                if (e.Key == Key.F5)
                {
                    var ans = MessageBox.Show("Are you sure you want to end transaction?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (ans == MessageBoxResult.Yes)
                    {
                        clearAll();
                    }
                }
            }

        }
    }
}
