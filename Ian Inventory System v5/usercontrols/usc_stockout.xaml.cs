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
using NavigationDrawerPopUpMenu2.reports;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_stockout : UserControl
    {
        Database conn = new Database();
        List<Stock_Out> stockOut = new List<Stock_Out>();
        string stockoutTransNo = "";
        string stockoutNo = "";
        string stockoutItem = "";
        string stockoutQty = "";
        string stockoutPrice = "";
        string stockoutDate = "";
        string stockoutStatus = "";
        string checkStockRepeat = "";
        public usc_stockout()
        {
            InitializeComponent();
        }

        // When UserControl Loads
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            transGenerator();
            ClearUnsavedDate();
            loadDataForRecord();
            changeQtyBtn.IsEnabled = false;
            removeStockOutBtn.IsEnabled = false;
            clearStockOutBtn.IsEnabled = false;
            saveStockOutBtn.IsEnabled = false;
        }

        // Delete All Unsaved Data
        public void ClearUnsavedDate()
        {
            try
            {
                conn.Open();
                // Query Statement
                string query = "DELETE FROM stock_out WHERE stockoutStatus = 'Stock Out Pending'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Load Data
        public void loadData()
        {
            try
            {

                // Query Statement
                string query = "SELECT * FROM stock_out WHERE stockoutTransNo = '" + orderNo.Text + "' AND stockoutStatus = 'Stock Out Pending'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("stock_out");
                // Fill the datatable
                adapter.Fill(dt);
                listViewinVoice.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                adapter.Dispose();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Load Data", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void loadDataForRecord()
        {
            try
            {
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM stock_out WHERE stockoutStatus = 'Stock Out' ORDER BY stockoutDate DESC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("stock_out");
                // Fill the datatable
                adapter.Fill(dt);
                listViewRecords.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                adapter.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Load Data", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Load Data For Other Forms
        public void loadDatas()
        {
            try
            {
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM stock_out WHERE stockoutTransNo = '" + orderNo.Text + "' AND stockoutStatus = 'Stock Out Pending'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("stock_out");
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
                MessageBox.Show(ex.Message, "Load Data", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Transaction # Generator
        public string transGenerator()
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
                        transGenerator();
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

        // Barcode Scan
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                clearStockOutBtn.IsEnabled = true;
                saveStockOutBtn.IsEnabled = true;
                string itemQty = "";
                string search = entrySearch.Text;
                string query = "SELECT * FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(query); //CMD 
                try
                {
                    bool isItemFound = false;
                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            isItemFound = true;
                            itemQty = dr["prodQty"].ToString();
                            stockoutTransNo = orderNo.Text;
                            stockoutNo = dr["prodNo"].ToString();
                            stockoutItem = dr["prodItem"].ToString();
                            stockoutQty = dr["prodQty"].ToString();
                            stockoutPrice = dr["prodRP"].ToString();
                            stockoutDate = DateTime.Now.ToString();
                            stockoutStatus = "Stock Out Pending";
                        }
                    }
                    else
                    {
                        isItemFound = false;
                    }

                    dr.Close();
                    dr.Dispose();
                    conn.Close();

                    if (!isItemFound)
                    {
                        MessageBox.Show("No item found", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {

                        // Check Item Quantity If Have Stock
                        if (int.Parse(itemQty) < 1)
                        {
                            MessageBox.Show("Item is out of stock", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        { // Add to the stockout table
                            string refno = "";
                            bool doesExist = false;
                            string check = "SELECT * FROM stock_out WHERE stockoutTransNo = '" + orderNo.Text + "' AND stockoutItem = '" + stockoutItem + "'";
                            conn.query(check);
                            conn.Open();
                            MySqlDataReader reader = conn.read();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    doesExist = true;
                                    refno = reader["stockoutId"].ToString();
                                    checkStockRepeat = reader["stockoutQty"].ToString(); // Stock Out Stock
                                }
                            }
                            else
                            {
                                doesExist = false;
                            }

                            reader.Close();
                            reader.Dispose();
                            conn.Close();
                            // If Item exist
                            if (doesExist == true)
                            {
                                // Check if item stock is still good
                                // itemQty = Datainventory stock // checkStockRepeat = stockout stock
                                if ((int.Parse(itemQty) - int.Parse(checkStockRepeat)) == 0)
                                {
                                    MessageBox.Show("No stock left in your database", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                else
                                {
                                    conn.Open();
                                    string addQuantityToExistingItem = "UPDATE stock_out SET stockoutQty = (stockoutQty + @qty) WHERE stockoutId = @refno";
                                    conn.query(addQuantityToExistingItem);
                                    conn.bind("@qty", 1);
                                    conn.bind("@refno", refno);
                                    conn.cmd().Prepare();
                                    var cf = conn.execute();
                                    if (cf == 1)
                                    {
                                        loadData(); // Display to ListView
                                        entrySearch.Text = "";
                                    }
                                    conn.Close();
                                }
                            }
                            else
                            { // if not exist then insert
                                string query2 = "INSERT INTO stock_out (stockoutTransNo, stockoutNo, stockoutItem, stockoutQty, stockoutPrice, stockoutDate, stockoutStatus) VALUES (@stockoutTransNo, @stockoutNo, @stockoutItem, @stockoutQty, @stockoutPrice, @stockoutDate, @stockoutStatus)";
                                conn.query(query2);
                                conn.Open();
                                conn.bind("@stockoutTransNo", orderNo.Text);
                                conn.bind("@stockoutNo", stockoutNo);
                                conn.bind("@stockoutItem", stockoutItem);
                                conn.bind("@stockoutQty", 1);
                                conn.bind("@stockoutPrice", stockoutPrice);
                                conn.bind("@stockoutDate", DateTime.Parse(stockoutDate));
                                conn.bind("@stockoutStatus", stockoutStatus);
                                conn.cmd().Prepare();
                                var cf = conn.execute();
                                if (cf == 1)
                                {
                                    // Adds Scanned Item to the Listview
                                    loadData(); // Display to ListView 
                                    entrySearch.Text = "";
                                }
                                conn.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Something went wrong, Try again later \n" + ex.Message, "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        // Validate Barcode Textbox Only Numbers
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var addDisc = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = addDisc.Text.Insert(addDisc.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        // Passing ListView Data to TextBox
        private void listViewinVoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                changeQtyBtn.IsEnabled = true;
                removeStockOutBtn.IsEnabled = true;
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

        // Remove Item from ListView
        private void removeStockOutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdName.Text.Equals(""))
            {
                MessageBox.Show("No Selected Item", "Remove Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                removeStockOutBtn.IsEnabled = false;
            }
            else
            {
                string query = "DELETE FROM stock_out WHERE stockoutTransNo = '" + orderNo.Text + "' AND stockoutItem = '" + tbPrdName.Text + "'";
                conn.query(query);
                try
                {
                    conn.Open();
                    conn.execute();
                    loadData();
                    conn.Close();
                    clearStockOutBtn.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Failed Removing Item, " + ex.Message, "Remove Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        // Remove ALL ITEM from ListView
        private void clearStockOutBtn_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Clear All?", "End Transaction", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                ClearUnsavedDate();
                conn.Open();
                loadData();
                conn.Close();
                saveStockOutBtn.IsEnabled = false;
            }
        }

        // Save Data
        private void saveStockOutBtn_Click(object sender, RoutedEventArgs e)
        {
            var ans = MessageBox.Show("Save your changes?", "Save", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ans == MessageBoxResult.Yes)
            {
                try
                {
                    string sql = "SELECT * FROM stock_out WHERE stockoutTransNo = '" + orderNo.Text + "' AND stockoutStatus = 'Stock Out Pending'";
                    conn.query(sql);
                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string stockoutTransNo = dr["stockoutTransNo"].ToString();
                            string stockoutNo = dr["stockoutNo"].ToString();
                            string stockoutItem = dr["stockoutItem"].ToString();
                            string stockoutQty = dr["stockoutQty"].ToString();
                            string stockoutPrice = dr["stockoutPrice"].ToString();
                            string stockoutDate = dr["stockoutDate"].ToString();
                            string stockoutId = dr["stockoutId"].ToString();
                            string stockoutStatus = dr["stockoutStatus"].ToString();

                            stockOut.Add(new Stock_Out { stockoutTransNo = stockoutTransNo, stockoutNo = stockoutNo, stockoutItem = stockoutItem, stockoutQty = stockoutQty, stockoutPrice = stockoutPrice, stockoutId = stockoutId, stockoutStatus = stockoutStatus });
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saving Failed: No Data Found", "Stock Out", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                    conn.Close();
                    dr.Close();
                    dr.Dispose();
                    // End of Query

                    // Second Query to SUBTRACT/UPDATE THE STOCKS
                    foreach (Stock_Out prd in stockOut)
                    {
                        conn.Open();
                        string updateStockQuery = "UPDATE datainventory SET prodQty = prodQty - '" + int.Parse(prd.stockoutQty) + "' WHERE prodNo = '" + prd.stockoutNo + "'";
                        conn.query(updateStockQuery);
                        conn.execute();
                        conn.Close();

                        conn.Open();
                        // Now Update the Status to SOLD
                        string updateStatus = "UPDATE stock_out SET stockoutStatus = 'Stock Out' WHERE stockoutNo = '" + prd.stockoutNo + "' AND stockoutTransNo = '" + orderNo.Text + "'";
                        conn.query(updateStatus);
                        conn.execute();
                        conn.Close();

                        //MessageBox.Show(prd.salesItem);
                    }
                    
                    report_stockout rptstockout = new report_stockout(this);
                    rptstockout.printPreview();
                    rptstockout.ShowDialog();
                    transGenerator(); // Generate a new Trans#
                    stockOut.Clear(); // Clear ListView
                    conn.Open();
                    loadData(); // Update UI
                    conn.Close();
                    loadDataForRecord();
                    MessageBox.Show("Your changes has been saved", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Saving Failed \n" + ex.Message, "Stock Out", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        // View All Products
        private void viewProdBtn_Click(object sender, RoutedEventArgs e)
        {
            win_view_all_products viewlist = new win_view_all_products();
            viewlist.ShowDialog();
        }

        // Change Quantity

        private void changeQtyBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (tbPrdName.Text != String.Empty)
            {
                win_changequantity_stockout changeQtyWindow = new win_changequantity_stockout(this, orderNo.Text);
                changeQtyWindow.ShowDialog();
            }
            else
            {
                changeQtyBtn.IsEnabled = false;
                MessageBox.Show("No Product Selected", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
