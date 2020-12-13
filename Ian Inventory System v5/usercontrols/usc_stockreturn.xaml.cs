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
    /// </summary>
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
                string query = "SELECT stockoutTransNo, stockoutItem, stockoutQty, stockoutDate, stockoutStatus FROM stock_out WHERE stockoutStatus = 'Stock Out'";
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
                MessageBox.Show(x.Message);
            }
        }

        // Populate textbox according to the trans #
        private void itemTransNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                conn.Close();
                if (itemTransNo.Text.Length > 0)
                {
                    itemReduce.IsEnabled = true;
                    itemReduce.Focus();
                    string searchTrans = itemTransNo.Text;
                    string query = "SELECT stockoutTransNo, stockoutNo, stockoutItem, stockoutQty, stockoutDate FROM stock_out WHERE stockoutTransNo = '" + searchTrans + "'";
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
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            int current, deduct;
            current = int.Parse(itemQty.Text);
            deduct = int.Parse(itemReduce.Text);

            toStock = (deduct + current);
            toRefund = (current - deduct);

            conn.Open();
            // Update datainventory Quantity
            string toAdd = "UPDATE datainventory SET prodQty = @Qty WHERE prodNo = @no";
            conn.query(toAdd);
            try
            {
                conn.bind("@Qty", toStock);
                conn.bind("@no", itemNo.Text);

                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("Refund Success!");
                    
                    reduceStocks();
                    fetchData();
                    conn.Close();
                    Clear();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
