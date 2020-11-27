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
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");

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
        }

        public UserControlCheckout(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public string Value { get; set; } // Create a variable to store the value

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
                con.Open();
                string payment = "INSERT INTO sales_preview (payment_method, payment_vat, payment_total, payment_paid, payment_due, payment_date) VALUES (@method, @vat, @total, @paid, @due, @date)";
                MySqlCommand cmddd = new MySqlCommand(payment, con);

                cmddd.Parameters.AddWithValue("@method", payMethod);
                cmddd.Parameters.AddWithValue("@vat", tax);
                cmddd.Parameters.AddWithValue("@total", total);
                cmddd.Parameters.AddWithValue("@paid", paid);
                cmddd.Parameters.AddWithValue("@due", due);
                cmddd.Parameters.AddWithValue("@date", DateTime.Now);
                var cff = cmddd.ExecuteNonQuery();
                if (cff == 1)
                {
                    MessageBox.Show("Success!");
                    entrySearch.IsReadOnly = true;
                    cashButton.IsEnabled = false;
                    voidEntry.IsEnabled = false;
                    endSale.IsEnabled = true;
                }
                con.Close();
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
        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            con.Close();
            // Barcode Text Changed
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;
                string query = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodBought FROM datainventory WHERE prodNo= '" + search + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
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
                    MessageBox.Show("Invalid Entry!");
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
                        MySqlCommand cmdd = new MySqlCommand(query2, con);

                        cmdd.Parameters.AddWithValue("@a", entrySearch.Text);
                        cmdd.Parameters.AddWithValue("@b", coItem.Text);
                        cmdd.Parameters.AddWithValue("@c", coBrand.Text);
                        cmdd.Parameters.AddWithValue("@d", coSRP.Text);
                        cmdd.Parameters.AddWithValue("@e", coRP.Text);
                        cmdd.Parameters.AddWithValue("@f", coQty.Text);
                        cmdd.Parameters.AddWithValue("@g", coSubtotal.Text);
                        cmdd.Parameters.AddWithValue("@h", DateTime.Now);
                        var cf = cmdd.ExecuteNonQuery();
                        if (cf == 1)
                        {
                            try
                            {
                                string ranking = "UPDATE datainventory SET prodBought = @bought WHERE prodNo = @itemNo";
                                MySqlCommand cmddd = new MySqlCommand(ranking, con);

                                cmddd.Parameters.AddWithValue("@itemNo", entrySearch.Text);
                                cmddd.Parameters.AddWithValue("@bought", coCurrentNew.Text);
                                var check = cmddd.ExecuteNonQuery();
                                if (check == 1)
                                {
                                    string remaining = "UPDATE datainventory SET prodQty = @rm WHERE prodNo = @ItemNo";
                                    conn.query(remaining);

                                    try
                                    {
                                        conn.Open();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Are you sure you want to void?", "Void", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }

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
