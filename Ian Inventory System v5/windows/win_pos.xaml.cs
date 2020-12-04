using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;
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


namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_pos : Window
    {
        window_userLogin lgn;
        Database conn = new Database();
        Checkout checkout = new Checkout();
        StocksCheck stocksck = new StocksCheck();
        Authentication auth;
        string transNo;
        string salesItem;
        string prodQty;
        public static int prdID;

        public win_pos(window_userLogin frmLogin)
        {
            InitializeComponent();
            auth = new Authentication("", "");
            lgn = frmLogin;
            entrySearch.Focus();
            accNumberGen();
        }

        // Window Loads
        private void WindowPOS_Loaded(object sender, RoutedEventArgs e)
        {
            // Display Time In
            timeIn.Text = DateTime.Now.ToLongTimeString();
            // Display Account Number
            accNo.Text = auth.getAccNo(lgn.txtUsername.Text);
            // Display Cashier Name
            cashierName.Text = auth.getFullName(accNo.Text);

            transTime.Text = DateTime.Now.ToString();

        }

        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text +"'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datasalesinventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewinVoice.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                adapter.Dispose();
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Transaction Number Generator
        public string accNumberGen()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 13; i++)
            {
                r += random.Next(0, 9).ToString();
                string query = "SELECT COUNT(1) FROM datasalesinventory WHERE salesTransNo = @order";
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
                    conn.Close();
                    MessageBox.Show(x.Message);
                }
            }
            return r;
        }

        // Logout Button
        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            auth.addTimeInOut(timeIn.Text, accNo.Text); // Bug 
            window_userLogin posLogin = new window_userLogin();
            posLogin.Show();
            this.Close();
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
            transTime.Text = DateTime.Now.ToLongTimeString();

            checkout.rmstocks = 0;
            checkout.subtotal = 0;
            checkout.vat = 0;
            checkout.total = 0;
            checkout.paid = 0;
            checkout.due = 0;
            cashAmount.Text = "₱ 0.00";

            checkout.total = 0;

            cashButton.IsEnabled = false;
            voucherButton.IsEnabled = false;
            othersButton.IsEnabled = false;
            voidEntry.IsEnabled = false;
            entrySearch.IsReadOnly = false;
            voucherButton.IsEnabled = false;
            othersButton.IsEnabled = false;
            holdOrder.IsEnabled = false;
            endSale.IsEnabled = false;
        }

        // Barcode Scanner Function
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                holdOrder.IsEnabled = false;
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
                // Enabled all the buttons
                cashButton.IsEnabled = true;
                voidEntry.IsEnabled = true;
                voucherButton.IsEnabled = true;
                othersButton.IsEnabled = true;
                //holdOrder.IsEnabled = true;

                // Here goes the math shits
                int rp = Convert.ToInt32(coRP.Text);
                int qty = Convert.ToInt32(coQty.Text);
                int cur = Convert.ToInt32(coCurrent.Text);
                int stk = Convert.ToInt32(coStocks.Text);
                int toit = Convert.ToInt32(totalItems.Text);
                int sub = rp * qty;

                // Here goes the math shits(2)
                checkout.rmstocks = stk - qty;
                checkout.total += checkout.vat + sub;
                checkout.bought = cur + qty;
                totalItems.Text = Convert.ToString(toit + qty);
                coRemStocks.Text = Convert.ToString(checkout.rmstocks);
                coSubtotal.Text = Convert.ToString(sub);
                pay_subtotal.Text = Convert.ToString(checkout.subtotal + sub);
                pay_total.Text = Convert.ToString(checkout.total);
                coCurrentNew.Text = Convert.ToString(checkout.bought);

                // Adds the data to the datasalesinventory
                if (coSubtotal.Text.Length > 0)
                {
                    // Insert Scanned Data to Database (datasalesinventory)
                    try
                    {
                        string query2 = "INSERT INTO datasalesinventory (salesTransNo, salesNo, salesItem, salesBrand, salesSRP, salesRP, salesQty, salesTotal, salesDate, salesStatus) VALUES (@no, @a, @b, @c, @d, @e, @f, @g, @h, @status)";
                        conn.query(query2);

                        conn.bind("@no", orderNo.Text);
                        conn.bind("@a", entrySearch.Text);
                        conn.bind("@b", coItem.Text);
                        conn.bind("@c", coBrand.Text);
                        conn.bind("@d", coSRP.Text);
                        conn.bind("@e", coRP.Text);
                        conn.bind("@f", coQty.Text);
                        conn.bind("@g", coSubtotal.Text);
                        conn.bind("@h", Convert.ToDateTime(transTime.Text));
                        conn.bind("@status", "Pending");
                        conn.cmd().Prepare();
                        var cf = conn.execute();
                        if (cf == 1)
                        {
                            // Subtracts the item quantity to the existing stocks in datainventory
                            try
                            {
                                string ranking = "UPDATE datainventory SET prodBought = @bought WHERE prodNo = @itemNo";
                                conn.query(ranking);

                                conn.bind("@itemNo", entrySearch.Text);
                                conn.bind("@bought", coCurrentNew.Text);

                                var check = conn.execute();

                                //  Updates the new remainding item quantity in datainventory
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

                            // Adds Scanned Item to the Listview
                            //listViewinVoice.Items.Add(new invoiceClass.gg { salesItem = coItem.Text, salesRP = rp.ToString(), salesQty = qty.ToString(), salesTotal = sub.ToString() });
                            clearPartial();
                            catchData();

                        }
                    }
                    catch (Exception x)
                    {
                        conn.Close();
                        MessageBox.Show(x.Message);
                        clearPartial();
                    }
                }
            }
        }

        // Void Button
        private void voidEntry_Click(object sender, RoutedEventArgs e)
        {
            // Confirmation Message
            conn.Close();
            var ans = MessageBox.Show("Are you sure you want to void?", "Void", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                // Updates the sales status to VOIDED
                string voidInvoice = "UPDATE datasalesinventory SET salesStatus = @void WHERE salesDate = @date";
                conn.query(voidInvoice);
                try
                {
                    conn.Open();

                    conn.bind("@void", "Voided");

                    string date = transTime.Text;
                    DateTime dateTime;
                    dateTime = DateTime.Parse(date);

                    conn.bind("@date", dateTime);

                    conn.execute();
                    MessageBox.Show("Item(s) Voided");
                    clearAll();
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Checkout Button
        private void endSale_Click(object sender, RoutedEventArgs e)
        {
            // Confirmation
            conn.Close();
            var ans = MessageBox.Show("Are you sure you want to end transaction?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                // Updates the sales status to COMPLETED
                string voidInvoice = "UPDATE datasalesinventory SET salesStatus = @complete WHERE salesDate = @date";
                conn.query(voidInvoice);
                try
                {
                    conn.Open();

                    conn.bind("@complete", "Completed");

                    string date = transTime.Text;
                    DateTime dateTime;
                    dateTime = DateTime.Parse(date);

                    conn.bind("@date", dateTime);
                    conn.execute();
                    clearAll();
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            checkout.payMethod = "Cash";
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
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
                conn.execute();

                entrySearch.IsReadOnly = true;
                cashButton.IsEnabled = false;
                voidEntry.IsEnabled = false;
                holdOrder.IsEnabled = false;
                othersButton.IsEnabled = false;
                voucherButton.IsEnabled = false;
                endSale.IsEnabled = true;
                conn.Close(); // Close Connection
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                clearPartial();
            }
        }

        // Price Check
        private void priceCheck_Click(object sender, RoutedEventArgs e)
        {
            win_priceCheck wpc = new win_priceCheck();
            wpc.ShowDialog();
        }

        // Update QTY
        private void updQtyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdName.Text != String.Empty)
            {
                window_change_quantity changeQtyWindow = new window_change_quantity(this, transNo, salesItem, prodQty);
                changeQtyWindow.ShowDialog();
            }
            else
            {
                holdOrder.IsEnabled = false;
                MessageBox.Show("No Product Selected", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        // IF CLICK ON LISTVIEW 
        private void listViewinVoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                holdOrder.IsEnabled = true;
                transNo = orderNo.Text;     // Transaction Number
                // Product Item Name
                salesItem = tbPrdName.Text;
                // GET THE SELECTED ITEM

                string selectedItem = listViewinVoice.SelectedItems[1].ToString();
                if (selectedItem != null) {
                    tbPrdName.Text = selectedItem;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        // Add Item Button
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            win_add_item wai = new win_add_item();
            wai.Show();
        }
    }
}
