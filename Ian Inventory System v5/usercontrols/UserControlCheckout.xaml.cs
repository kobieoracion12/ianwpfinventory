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
        string stockoutTransNo = "";
        string stockoutNo = "";
        string stockoutItem = "";
        string stockoutQty = "";
        string stockoutPrice = "";
        string stockoutDate = "";
        string stockoutStatus = "";

        public UserControlCheckout()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            transGenerator();
            ClearUnsavedDate(); 
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
                string itemQty = "";
                string search = entrySearch.Text;
                string query = "SELECT * FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(query); //CMD 
                try
                {

                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
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
                        MessageBox.Show("No item found, Try again later", "Scan Item", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                    dr.Close();
                    dr.Dispose();
                    conn.Close();

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

        // Change Quantity
        private void ChangeQty_Click(object sender, RoutedEventArgs e)
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

        // Passing ListView Data to TextBox
        private void listViewinVoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                changeQtyBtn.IsEnabled = true;     
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
    }
}
