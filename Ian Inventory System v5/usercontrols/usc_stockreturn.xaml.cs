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
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_stockreturn : UserControl
    {
        Database conn = new Database();
        public usc_stockreturn()
        {
            InitializeComponent();
            fetchData();
        }

        // Fetch data from database
        public void fetchData()
        {
            conn.Close();
            try
            {
                // Open Connection
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
                lv_browse.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Search Function Method
        public void searchData()
        {
            conn.Close();
            try
            {
                conn.Open();
                string search = itemo.Text;
                string query = "SELECT stockoutTransNo, stockoutItem, stockoutQty, stockoutDate FROM stock_out WHERE stockoutNo LIKE '%" + search + "%' AND stockoutStatus = 'Stock Out'";
                conn.query(query);
                conn.execute();
                MySqlDataAdapter adapter = conn.adapter();
                DataTable dt = new DataTable("stock_out");
                adapter.Fill(dt);
                lv_browse.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                adapter.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Fetch Remaining Stocks from the inventory
        public void searchQty()
        {
            conn.Close();
            try
            {
                conn.Open();
                string id = itemNo.Text;
                string query = "SELECT prodQty FROM datainventory WHERE prodNo = '" + id + "'";
                conn.query(query);
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0) };
                    curQty.Text = row[0];
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Deducts the returned stocks from the database
        public void reduceStocks()
        {
            conn.Close();
            try
            {
                string reduce = "UPDATE stock_out SET stockoutQty = @qty WHERE stockoutNo = @no";
                conn.query(reduce);
                conn.Open();
                conn.bind("@qty", toRefund);
                conn.bind("@no", itemNo.Text);
                var ch = conn.execute();
                if (ch == 1)
                {
                    MessageBox.Show("Success!");
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Search Bar
        private void itemo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (itemo.Text.Length == 0)
            {
                fetchData();
            }
            else if (itemo.Text.Length > 0)
            {
                searchData();
            }
        }

        // Selects the selected items in the listview
        private void lv_browse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the product id
                string prodId = lv_browse.SelectedItems[0].ToString();
                // Append ID and Product name
                itemTransNo.Text = prodId;

            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Clear Function
        public void Clear()
        {
            itemo.Clear();
            itemTransNo.Clear();
            itemName.Clear();
            itemNo.Clear();
            itemQty.Clear();
            itemReduce.Clear();
            curQty.Text = "";
            itemDOP.Text = "";
        }

        // Return Item Button
        public int toRefund, toStock;
        
        // Populate Textboxes
        private void stockid_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                conn.Close();
                if (stockid.Text.Length > 0)
                {
                    itemReduce.IsEnabled = true;
                    itemReduce.Focus();
                    string searchId = stockid.Text;
                    string query = "SELECT stockoutTransNo, stockoutNo, stockoutItem, stockoutQty, stockoutDate FROM stock_out WHERE stockoutId = '" + searchId + "'";
                    conn.query(query); //CMD 
                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.Read())
                    {
                        itemTransNo.Text = dr.GetValue(0).ToString();
                        itemNo.Text = dr.GetValue(1).ToString();
                        itemName.Text = dr.GetValue(2).ToString();
                        itemQty.Text = dr.GetValue(3).ToString();
                        itemDOP.Text = dr.GetValue(4).ToString();
                        dr.Close();
                        dr.Dispose(); // Dispose
                        searchQty();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Clear
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        // Add Button
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (itemTransNo.Text == "" || itemNo.Text == "" || itemName.Text == "" || itemQty.Text == "" || itemReduce.Text == "" || itemDOP.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty", "Stock Return", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (int.Parse(itemReduce.Text) > int.Parse(itemQty.Text))
                {
                    MessageBox.Show("Unable to proceed, your input is too large", "Stock Return", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (int.Parse(itemQty.Text) == int.Parse(itemReduce.Text))
                {
                    ////
                    string query = "UPDATE datainventory SET prodQty = (prodQty + @prodQty) WHERE prodNo = @prodNo";
                    conn.query(query);
                    conn.Open();
                    conn.bind("@prodQty", itemReduce.Text);
                    conn.bind("@prodNo", itemNo.Text);
                    conn.cmd().Prepare();
                    var success = conn.execute();
                    if (success > 0)
                    {
                        MessageBox.Show(itemReduce.Text + " has been returned to the database", "Stock Return", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    conn.Close();

                    ////
                    // Delete this stock out item record
                    string removeRecord = "DELETE FROM stock_out WHERE stockoutTransNo = @transno AND stockoutNo = @prodno";
                    conn.query(removeRecord);
                    conn.Open();
                    conn.bind("@transno", itemTransNo.Text);
                    conn.bind("@prodno", itemNo.Text);
                    conn.cmd().Prepare();
                    conn.execute();

                    conn.Close();

                    fetchData();
                    Clear();
                }
                else
                {
                    ////
                    string query = "UPDATE datainventory SET prodQty = (prodQty + @prodQty) WHERE prodNo = @prodNo";
                    conn.query(query);
                    conn.Open();
                    conn.bind("@prodQty", itemReduce.Text);
                    conn.bind("@prodNo", itemNo.Text);
                    conn.cmd().Prepare();
                    var success = conn.execute();
                    if (success > 0)
                    {
                        MessageBox.Show(itemReduce.Text + " has been returned to the database", "Stock Return", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    conn.Close();
                    ////

                    ////
                    string reduceFromStockout = "UPDATE stock_out SET stockoutQty = (stockoutQty - @stockoutQty) WHERE stockoutTransNo = @transno AND stockoutNo = @stockoutNo";
                    conn.query(reduceFromStockout);
                    conn.Open();
                    conn.bind("@transno", itemTransNo.Text);
                    conn.bind("@stockoutQty", itemReduce.Text);
                    conn.bind("@stockoutNo", itemNo.Text);
                    conn.cmd().Prepare();
                    conn.execute();
                    conn.Close();
                    ////


                    fetchData();
                    Clear();
                }
               

            } catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Failed to return item, try again later", "Stock Return", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
                    
        }
    }
}
