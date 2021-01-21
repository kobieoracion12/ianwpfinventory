﻿using NavigationDrawerPopUpMenu2.classes;
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
        public static string discount = "0";
        string transNo;
        string salesItem;
        public static int prdID;
        string checkStockRepeat = "";
        int checkQty = 0;
        bool isItemFound = false;
        string productCategory = "";

        List<Invoice> settleProducts = new List<Invoice>();
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
            // Discount Disabled 
            discountItem.IsEnabled = false;
            // Remove Button
            removeItem.IsEnabled = false;
            // Display Time In
            timeIn.Text = DateTime.Now.ToLongTimeString();
            // Display Account Number
            accNo.Text = auth.getAccNo(lgn.txtUsername.Text);
            // Display Cashier Name
            cashierName.Text = auth.getFullName(accNo.Text);

            transTime.Text = DateTime.Now.ToString();
        }

        // DISPLAY THE ITEMS INTO THE LISTVIEW
        public void loadData()
        {
            try
            {

                // Query Statement
                string query = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesStatus = 'Pending'";
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

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDatas()
        {
            try
            {
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesStatus = 'Pending'";
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
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // GET AND DISPLAY THE TOTAL SALES/DUE
        public String sumOfSalesTotal()
        {
            string total = "";
            try
            {
                conn.Close();

                // GET THE TOTAL SALES    
                conn.Open(); 
                string query = "SELECT SUM(salesTotal + salesVAT) as total_due FROM `datasalesinventory` WHERE salesTransNo = @transno AND salesStatus=@status GROUP BY salesTransNo";
                conn.query(query);

                conn.bind("@transno", orderNo.Text);
                conn.bind("@status", "Pending");
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        total = dr["total_due"].ToString(); // TOTAL SUM OF SALESTOTAL
                    }
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Total", MessageBoxButton.OK, MessageBoxImage.Warning);
                conn.Close();
            }
            return total;
        }

        public String sumOfSalesTotals()
        {
            conn.Close();
            string total = "";
            try
            {
                conn.Open();
                // GET THE TOTAL SALES     
                string query = "SELECT SUM(salesTotal) as totals FROM `datasalesinventory` WHERE salesTransNo = @transno AND salesStatus=@status GROUP BY salesTransNo";
                conn.query(query);

                conn.bind("@transno", orderNo.Text);
                conn.bind("@status", "Pending");
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        total = dr["totals"].ToString(); // TOTAL SUM OF SALESTOTAL
                    }
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Total", MessageBoxButton.OK, MessageBoxImage.Warning);
                conn.Close();
            }
            return total;
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
            bool hasProducts = false;
            try
            {
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = conn.adapter();

                string query = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesStatus = 'Pending'";
                conn.query(query);
                adapter.SelectCommand = conn.cmd();

                adapter.Fill(table);

                if (table.Rows.Count > 0) // Found
                {
                    hasProducts = true;
                }
                else
                { // No Users Found
                    hasProducts = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Logout Failed, " + ex.Message, "Logout", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (hasProducts)
            {
                MessageBox.Show("Unable to proceed, please clear your transaction", "Logout", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ans == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Logout Success!", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
                    window_userLogin userLogin = new window_userLogin();
                    userLogin.Show(); // Show Login After Logout
                    this.Close(); // Close this window
                    //auth.addTimeInOut(DateTime.Parse(timeIn.Text) , accNo.Text); 
                }
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
            //listViewinVoice.Items.Clear();
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
            pay_subtotal.Text = "0.00";
            pay_total.Text = "0.00";
            pay_paid.Text = "0.00";
            pay_due.Text = "0.00";
            pay_tax.Text = "0";
            vatItem.Text = "0";
            transTime.Text = DateTime.Now.ToLongTimeString();

            checkout.rmstocks = 0;
            checkout.subtotal = 0;
            checkout.vat = 0;
            checkout.total = 0;
            checkout.paid = 0;
            checkout.due = 0;
            cashAmount.Text = "0.00";

            checkout.total = 0;

            cashButton.IsEnabled = false;
            //othersButton.IsEnabled = false;
            voidEntry.IsEnabled = false;
            entrySearch.IsReadOnly = false;
            holdOrder.IsEnabled = false;
            endSale.IsEnabled = false;
        }

        // Barcode Scanner Function
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                pay_discount.Text = "0";
                holdOrder.IsEnabled = false;
                conn.Close();
                string search = entrySearch.Text;
                string query = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodVAT, prodBought, prodCategory FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(query); //CMD 
                conn.Open();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        isItemFound = true; // Check if item is found
                        coItem.Text = dr.GetValue(0).ToString();
                        coBrand.Text = dr.GetValue(1).ToString();
                        coStocks.Text = dr.GetValue(2).ToString();
                        coSRP.Text = dr.GetValue(3).ToString();
                        coRP.Text = dr.GetValue(4).ToString();
                        vatItem.Text = dr.GetValue(5).ToString();
                        coCurrent.Text = dr.GetValue(6).ToString();
                        productCategory = dr["prodCategory"].ToString();


                        stocksck.productQty = Convert.ToInt32(dr.GetValue(2));
                        checkQty = Convert.ToInt32(stocksck.productQty);
                        if (checkQty >= 1)
                        {
                            // Closes the reader so the next query will work            
                            dr.Close();
                            dr.Dispose(); // Dispose
                            Compute();
                        }
                        else
                        {
                            MessageBox.Show("Item is out of stock", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                            clearPartial();
                            conn.Close();
                            return;
                        }
                    }
                    else
                    {
                        isItemFound = false;
                        clearPartial();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No item found", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                    isItemFound = false;
                    dr.Close();
                    dr.Dispose(); // Dispose
                    clearPartial();
                    conn.Close();
                }

            }
        }

        // Computes Recieved Data from Barcode
        public void Compute()
        {
            // Check if item is found

            // IF ITEM FOUND IN THE DATABASE
            // Math Goes Here....
            if (coRP.Text.Length > 0)
            {
                // Enabled all the buttons
                discountItem.IsEnabled = true;
                cashButton.IsEnabled = true;
                voidEntry.IsEnabled = true;
                //othersButton.IsEnabled = true;
                //holdOrder.IsEnabled = true;

                // Here goes the math shits
                int rp = Convert.ToInt32(coRP.Text); // Retail Price
                int qty = Convert.ToInt32(coQty.Text); // Quantity
                int cur = Convert.ToInt32(coCurrent.Text); // Current Stocks
                int stk = Convert.ToInt32(coStocks.Text); // Stocks
                double vi = Convert.ToDouble(vatItem.Text); // VAT Per Item

                int sub = rp * qty;

                checkout.rmstocks = stk - qty; // Remaining Stocks Based on How Many Are Bought
                checkout.vat = Convert.ToInt32(vi) * qty;
                checkout.total += Convert.ToInt32(vi) + sub; // Subtotal
                checkout.bought = cur + qty; // For Ranking

                coRemStocks.Text = Convert.ToString(checkout.rmstocks); // Shows the Remaining Item Upon Buy
                coSubtotal.Text = Convert.ToString(sub); // (Price * Qunatity)
                pay_subtotal.Text = Convert.ToString(checkout.subtotal + sub); // Subtotal + (Price * Quantity)
                pay_tax.Text = Convert.ToString(vi);
                coCurrentNew.Text = Convert.ToString(checkout.bought);

                // Adds the data to the datasalesinventory
                if (coSubtotal.Text.Length > 0)
                {
                    conn.Close();
                    // Insert Scanned Data to Database (datasalesinventory)
                    try
                    {
                        conn.Open();
                        string refno = "";
                        bool doesExist = false;
                        string check = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesItem = '" + coItem.Text + "'";
                        conn.query(check);
                        MySqlDataReader reader = conn.read();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                doesExist = true;
                                refno = reader["refNo"].ToString();
                                checkStockRepeat = reader["salesQty"].ToString(); // Datasalesinventory Stock
                            }
                        }
                        else
                        {
                            doesExist = false;
                        }

                        reader.Close();
                        reader.Dispose();

                        try
                        {
                            /////
                            // If Item exist
                            if (doesExist == true)
                            {
                                // Check if item stock is still good
                                // checkQty = Datainventory stock // checkStockRepeat = datasalesinventory stock
                                if ((checkQty - int.Parse(checkStockRepeat)) == 0)
                                {
                                    MessageBox.Show("No stock left in your database", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                                    conn.Close();
                                }
                                else
                                {
                                    conn.Close();
                                    conn.Open();
                                    string addQuantityToExistingItem = "UPDATE datasalesinventory SET salesQty = (salesQty + @qty) WHERE refNo = @refno";
                                    conn.query(addQuantityToExistingItem);
                                    conn.bind("@qty", 1);
                                    conn.bind("@refno", refno);
                                    conn.cmd().Prepare();
                                    var cf = conn.execute();
                                    if (cf == 1)
                                    {
                                        string updTotal = "UPDATE datasalesinventory SET salesTotal = (salesRP * salesQty), salesVAT = (salesVAT + '" + double.Parse(vatItem.Text) + "') WHERE salesTransNo = '" + orderNo.Text + "' AND refNo = '" + refno + "' ";
                                        conn.query(updTotal);
                                        conn.execute();
                                        // Adds Scanned Item to the Listview
                                        //listViewinVoice.Items.Add(new invoiceClass.gg { salesItem = coItem.Text, salesRP = rp.ToString(), salesQty = qty.ToString(), salesTotal = sub.ToString() });
                                        clearPartial();
                                        loadData(); // Display to ListView 
                                        checkout.paytotal = double.Parse(sumOfSalesTotal());
                                        pay_total.Text = Convert.ToString(checkout.paytotal);
                                        pay_tax.Text = sumOfTotalVat(); // Total Vat
                                    }
                                }

                            }
                            else
                            { // if not exist then insert
                                conn.Close();
                                conn.Open();
                                string query2 = "INSERT INTO datasalesinventory (salesTransNo, salesNo, salesItem, salesBrand, salesSRP, salesRP, salesVAT, salesQty, salesTotal, salesDate, salesStatus, salesCategory) VALUES (@no, @barcode, @name, @brand, @srp, @rp, @vat, @qty, @subtotal, @date, @status, @categ)";
                                conn.query(query2);
                                conn.bind("@no", orderNo.Text);
                                conn.bind("@barcode", entrySearch.Text);
                                conn.bind("@name", coItem.Text);
                                conn.bind("@brand", coBrand.Text);
                                conn.bind("@srp", coSRP.Text);
                                conn.bind("@rp", coRP.Text);
                                conn.bind("@vat", double.Parse(vatItem.Text));
                                conn.bind("@qty", coQty.Text);
                                conn.bind("@subtotal", coSubtotal.Text);
                                conn.bind("@date", Convert.ToDateTime(transTime.Text));
                                conn.bind("@status", "Pending");
                                conn.bind("@categ", productCategory);
                                conn.cmd().Prepare();
                                var cf = conn.execute();
                                if (cf == 1)
                                {
                                    // Adds Scanned Item to the Listview
                                    //listViewinVoice.Items.Add(new invoiceClass.gg { salesItem = coItem.Text, salesRP = rp.ToString(), salesQty = qty.ToString(), salesTotal = sub.ToString() });
                                    clearPartial();
                                    loadData(); // Display to ListView 
                                    pay_total.Text = Convert.ToString(sumOfSalesTotal());
                                    pay_tax.Text = sumOfTotalVat(); // Total Vat
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            conn.Close();
                            MessageBox.Show("Something went wrong\n" + ex.Message, "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    catch (Exception x)
                    {
                        conn.Close();
                        MessageBox.Show(x.Message, "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                        clearPartial();
                    }
                }
            }

        }

        private String sumOfTotalVat()
        {
            conn.Close();
            string total = "";
            try
            {
                // GET THE TOTAL SALES   
                conn.Open();  
                string query = "SELECT SUM(salesVAT) as total_vat FROM `datasalesinventory` WHERE salesTransNo = @transno AND salesStatus = @status GROUP BY salesTransNo";
                conn.query(query);

                conn.bind("@transno", orderNo.Text);
                conn.bind("@status", "Pending");
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        total = dr["total_vat"].ToString(); // TOTAL SUM OF SALESTOTAL
                    }
                }
                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "VAT", MessageBoxButton.OK, MessageBoxImage.Warning);
                conn.Close();
            }
            return total;
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

                listViewinVoice.ClearValue(ItemsControl.ItemsSourceProperty);
                string voidInvoice = "UPDATE datasalesinventory SET salesStatus = @cancel WHERE salesTransNo = @trans";
                conn.query(voidInvoice);
                try
                {
                    conn.Open();

                    conn.bind("@cancel", "Cancelled");
                    conn.bind("@trans", Convert.ToInt64(orderNo.Text));
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
            var ans = MessageBox.Show("Are you sure you want to end transaction?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                try
                {
                    // Start a Query
                    string sql = "SELECT * FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesStatus = 'Pending'";
                    conn.query(sql);
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string sales_transno = reader["salesTransNo"].ToString(); // Trans No
                            string sales_no = reader["salesNo"].ToString(); // Sales No
                            string sales_item = reader["salesItem"].ToString(); // Sales Item
                            string sales_rp = reader["salesRP"].ToString(); // Sales RP
                            string sales_qty = reader["salesQty"].ToString(); // Sales Qty
                            string sales_total = reader["salesTotal"].ToString(); // Sales Total
                            string sales_status = reader["salesStatus"].ToString();  // Sales Status
                                                                                     // Add Objects/Element to ListView Settle to get the Invoice Products
                            settleProducts.Add(new Invoice { salesTransno = sales_transno, salesNo = sales_no, salesItem = sales_item, salesRP = sales_rp, salesQty = sales_qty, salesTotal = sales_total, salesStatus = sales_status });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Products", "Notice", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }

                    reader.Close();
                    reader.Dispose();
                    conn.Close();
                    // End of Query

                    // Second Query to SUBTRACT/UPDATE THE STOCKS
                    foreach (Invoice prd in settleProducts)
                    {
                        conn.Open();
                        string updateStockQuery = "UPDATE datainventory SET prodQty = prodQty - '" + int.Parse(prd.salesQty) + "', prodBought = prodBought + '"+ int.Parse(prd.salesQty) + "' WHERE prodNo = '" + prd.salesNo + "'";
                        conn.query(updateStockQuery);
                        conn.execute();
                        conn.Close();

                        conn.Open();
                        // Now Update the Status to SOLD
                        string updateStatus = "UPDATE datasalesinventory SET salesStatus = 'Sold' WHERE salesNo = '" + prd.salesNo + "' AND salesTransNo = '" + orderNo.Text + "'";
                        conn.query(updateStatus);
                        conn.execute();
                        conn.Close();

                        //MessageBox.Show(prd.salesItem);
                    }

                    // Show Transaction Success
                    MessageBox.Show("Transaction Complete", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    accNumberGen(); // Change the transaction Number
                    settleProducts.Clear(); // Clear All SettleProduct Objects/Elementss    
                    conn.Open();
                    loadData(); // Update the ListView UI # Listview must be cleared
                    conn.Close();
                    clearAll();
                    pay_tax.Text = "0.00";
                    vatItem.Text = "0";

                    discountItem.IsEnabled = false;
                    removeItem.IsEnabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Transaction Failed: " + ex.Message, "Transaction", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            checkout.payMethod = "Cash";
            window_cashButton cf = new window_cashButton();
            cf.total(pay_total.Text);
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }

        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            checkout.paid = Convert.ToInt32(msg);
            cashAmount.Text = Convert.ToString(checkout.paid);
            pay_paid.Text = Convert.ToString(checkout.paid);

            /*
            checkout.due = checkout.paid - Convert.ToInt32(sumOfSalesTotal());
            pay_due.Text = Convert.ToString(checkout.due);
            */

            // Check if Total is Null or Nothing
            if (sumOfSalesTotal() == "")
            {
                checkout.due = 0;
                pay_due.Text = Convert.ToString(checkout.due);
            }
            else
            {
                double total = double.Parse(pay_total.Text);
                checkout.due = (checkout.paid - total);
                pay_due.Text = Convert.ToString(checkout.due);
            }

            try
            {
                conn.Close();
                conn.Open();
                string payment = "INSERT INTO sales_preview (payment_method, payment_vat, payment_total, payment_paid, payment_due, payment_date) VALUES (@method, @vat, @total, @paid, @due, @date)";
                conn.query(payment);  // Command DB
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
                //othersButton.IsEnabled = false;
                endSale.IsEnabled = true;


                // Generate a Receipt
                win_receipt rcpt = new win_receipt(this);
                rcpt.loadReport();
                rcpt.ReportViewerDemo.LocalReport.Print();
                discountItem.IsEnabled = false;
                removeItem.IsEnabled = false;

                //rcpt.ShowDialog();
                // End of Receipt
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                clearPartial();
                conn.Close();
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
                window_change_quantity changeQtyWindow = new window_change_quantity(this, transNo, salesItem);
                changeQtyWindow.ShowDialog();
            }
            else
            {
                holdOrder.IsEnabled = false;
                MessageBox.Show("No Product Selected", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // IF CLICK ON LISTVIEW - Pass Data to TextBox to Listview
        private void listViewinVoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                holdOrder.IsEnabled = true;
                removeItem.IsEnabled = true;
                transNo = orderNo.Text;     // Transaction Number
                // Product Item Name
                salesItem = tbPrdName.Text;
                // GET THE SELECTED ITEM

                string selectedItem = listViewinVoice.SelectedItems[1].ToString();
                if (selectedItem != null)
                {
                    tbPrdName.Text = selectedItem;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        // Add Item Button
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            win_add_item wai = new win_add_item(this);
            wai.ShowDialog();

        }

        // Settings Button
        private void cashierSettings_Click(object sender, RoutedEventArgs e)
        {
            win_settings ws = new win_settings(this);
            ws.ShowDialog();
        }

        // Remove Item from Listview
        private void removeItem_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdName.Text.Equals(""))
            {
                MessageBox.Show("No Selected Item", "Remove Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                conn.Close();
            }
            else
            {
                string query = "DELETE FROM datasalesinventory WHERE salesTransNo = '" + orderNo.Text + "' AND salesItem = '" + tbPrdName.Text + "'";
                conn.Open();
                conn.query(query);
                try
                {
                    conn.execute();
                    loadData();

                    if (sumOfSalesTotal() == "")
                    {
                        pay_total.Text = "0.00";
                        pay_subtotal.Text = "0.00";
                        pay_tax.Text = "0.00";
                        vatItem.Text = "0.00";
                        discountItem.IsEnabled = false;
                        endSale.IsEnabled = false;
                        cashButton.IsEnabled = false;
                        //othersButton.IsEnabled = false;
                        conn.Close();
                    }
                    else
                    {
                        pay_total.Text = sumOfSalesTotal(); // Update the Total
                        pay_subtotal.Text = sumOfSalesTotal(); // Update the Subtotal
                        pay_tax.Text = sumOfTotalVat(); // Update Total Vat
                        clearPartial();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Failed Removing Item, " + ex.Message, "Remove Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                    conn.Close();
                }
            }

        }

        // Discount
        private void discountItem_Click(object sender, RoutedEventArgs e)
        {
            addDiscount addDiscWindow = new addDiscount(this);
            addDiscWindow.ShowDialog();
        }

        // Shortcut Keys
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.F1)
                voidEntry_Click(sender, e); // Void
            else if (e.Key == Key.F2)
                updQtyBtn_Click(sender, e); // Quantity
            else if (e.Key == Key.F3 && endSale.IsEnabled == true)
                endSale_Click(sender, e); // Checkout
            else if (e.Key == Key.F4 && cashButton.IsEnabled == true)
                cashButton_Click(sender, e); // Cash Button
            else if (e.Key == Key.F5)
                discountItem_Click(sender, e); // Discount
            else if (e.Key == Key.Delete)
                removeItem_Click(sender, e); // Remove Item Button
            else if (e.Key == Key.Insert)
                addItem_Click(sender, e); // Add Item
            else if (e.Key == Key.F7)
                priceCheck_Click(sender, e); // Price Check
            else if (e.Key == Key.F12)
                cashierSettings_Click(sender, e);

        }

        // Refund Item
        private void refundItem_Click(object sender, RoutedEventArgs e)
        {
            win_refund wrf = new win_refund();
            wrf.ShowDialog();
        }
    }
}
