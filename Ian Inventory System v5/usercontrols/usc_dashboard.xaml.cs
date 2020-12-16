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

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_dashboard : UserControl
    {
        Database conn = new Database();
        public usc_dashboard()
        {
            InitializeComponent();
            genProfit();
            overallSales();
            ordersCompleted();
            criticalItems();
            topSelling();
            outTotal();
            critTotal();
            stocksTotal();
            lineTotal();
        }

        // Out of Stock Total
        public void outTotal()
        {
            conn.Close();
            string query = "SELECT COUNT(prodQty) FROM datainventory WHERE prodQty = 0";
            conn.query(query);

            try
            {
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    outNo.Text = dr.GetValue(0).ToString();
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Critical Items Total
        public void critTotal()
        {
            conn.Close();
            string query = "SELECT COUNT(prodQty) FROM datainventory WHERE prodQty <= 10 AND prodQty >= 1";
            conn.query(query);

            try
            {
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    critNo.Text = dr.GetValue(0).ToString();
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Stocks on Hand Total
        public void stocksTotal()
        {
            conn.Close();
            string query = "SELECT SUM(prodQty) FROM datainventory WHERE prodQty > 1";
            conn.query(query);

            try
            {
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    stocksNo.Text = dr.GetValue(0).ToString();
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Stocks on Hand Total
        public void lineTotal()
        {
            conn.Close();
            string query = "SELECT COUNT(prodNo) FROM datainventory";
            conn.query(query);

            try
            {
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    lineNo.Text = dr.GetValue(0).ToString();
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Critical Items
        public void criticalItems()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT prodNo, prodItem, prodQty FROM datainventory WHERE prodQty BETWEEN 1 AND 10 ORDER BY prodQty DESC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewStocks.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose();  // Dispose Adapter
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Top Selling Items
        public void topSelling()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT prodNo, prodItem, prodBought FROM datainventory WHERE prodBought ORDER BY prodBought DESC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listviewTop.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose();  // Dispose Adapter
                                    // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Generated Profit
        private void genProfit()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesRP) - SUM(salesSRP) FROM datasalesinventory";
            conn.query(query);
            try
            {
                // Open Connection
                conn.Open();
                // Execute 
                MySqlDataReader dr = conn.read();

                if (dr.Read())
                {
                    tb_profitSales.Text = dr.GetValue(0).ToString();
                    if (tb_profitSales.Text == "")
                    {
                        tb_profitSales.Text = "₱ 0.00";
                    }
                }

                dr.Close();// ReaderClose
                dr.Dispose(); // Reader Dispose
                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Overall Sales 
        private void overallSales()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(payment_total) FROM sales_preview";
            conn.query(query);

            try
            {
                // Open Connection
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    tb_overallSales.Text = "₱ " + dr.GetValue(0).ToString();
                    if (tb_overallSales.Text == "₱")
                    {
                        tb_overallSales.Text = "₱ 0.00";
                    }
                }

                dr.Close();// ReaderClose
                dr.Dispose(); // Reader Dispose
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Orders Completed
        private void ordersCompleted()
        {
            dateTimeNow.Text = DateTime.Now.ToLongDateString();
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesQty) FROM datasalesinventory";
            conn.query(query);

            try
            {
                // Open Connection
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    ordersCom1.Text = dr.GetValue(0).ToString();
                    ordersCom2.Text = dr.GetValue(0).ToString();
                }

                dr.Close();// ReaderClose
                dr.Dispose(); // Reader Dispose
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

    }
}
