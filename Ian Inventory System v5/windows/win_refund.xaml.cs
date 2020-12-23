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
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_refund : Window
    {
        Database conn = new Database();
        Refund refunds = new Refund();
        public win_refund()
        {
            InitializeComponent();
            itemQuantity.IsEnabled = false;
            itemRefund.IsEnabled = false;
            fetchData();
            searchTrans.Focus();
        }
        public string transNumber;

        // Fetch Sold Data
        public void fetchData()
        {
            try
            {
                conn.Close();
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT refNo, salesNo, salesItem, salesQty, salesTotal, salesDate FROM datasalesinventory WHERE salesStatus = 'Sold' ORDER BY refNo DESC";
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
                lv_browse.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }

        // Searched Data
        public void searchData()
        {
            conn.Close();
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT refNo, salesNo, salesItem, salesQty, salesTotal, salesDate FROM datasalesinventory WHERE salesTransNo = '" + transNumber + "' ORDER BY refNo DESC";
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
                lv_browse.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }
        
        // Search Function
        private void searchTrans_TextChanged(object sender, TextChangedEventArgs e)
        {
            transNumber = searchTrans.Text;

            if (searchTrans.Text.Length == 0)
            {
                fetchData();
            }
            else if (searchTrans.Text.Length > 0)
            {
                searchData();
            }
        }

        
        // Selection Change Event Handler 
        private void lv_browse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the product id
                string prodId = lv_browse.SelectedItems[0].ToString();
                string prodQty = lv_browse.SelectedItems[1].ToString();
                string prodRef = lv_browse.SelectedItems[2].ToString();
                // Append ID and Product name
                slcNo.Text = prodId;
                slcQty.Text = prodQty;
                refNo.Text = prodRef;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        
        // Refund Button
        private void itemRefund_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string qtyCheck = "SELECT prodQty FROM datainventory WHERE prodNo = '" + slcNo.Text + "'";
                conn.query(qtyCheck);

                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0) };
                    curQty.Text = row[0];
                    reader.Close();

                    if (curQty.Text.Length > 0)
                    {
                        int current, refund, toStock;
                        current = int.Parse(curQty.Text);
                        refund = int.Parse(slcQty.Text);

                        toStock = current + refund;

                        string restock = "UPDATE datainventory SET prodQty = @Qty WHERE prodNo = @no";
                        conn.query(restock);
                        try
                        {
                            conn.bind("@Qty", toStock);
                            conn.bind("@no", slcNo.Text);

                            var check = conn.execute();
                            if (check == 1)
                            {
                                MessageBox.Show("Refund Success!");
                                updateStock();
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Item not Found");
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }

        // Update Function
        public void updateStock()
        {
            conn.Close();
            try
            {
                conn.Open();
                string restock = "UPDATE datasalesinventory SET salesStatus = @status WHERE refNo = @ref";
                conn.query(restock);

                conn.bind("@status", "Refunded");
                conn.bind("@ref", refNo.Text);
                var ch = conn.execute();
                if (ch == 1)
                {
                    fetchData();
                    searchTrans.Focus();
                    searchTrans.Clear();
                    curQty.Clear();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("updatestock error");
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }

        // Quantity Button
        private void itemQuantity_Click(object sender, RoutedEventArgs e)
        {
            win_change_qty wcq = new win_change_qty(refNo.Text, slcNo.Text, this);
            wcq.ShowDialog();
        }

        // ListView
        private void lv_browse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            itemQuantity.IsEnabled = true;
            itemRefund.IsEnabled = true;
        }
    }
}
