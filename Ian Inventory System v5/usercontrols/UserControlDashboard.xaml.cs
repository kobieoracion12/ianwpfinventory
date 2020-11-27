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
using LiveCharts;
using LiveCharts.Wpf;
using System;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlDashboard : UserControl
    {
        Database conn = new Database();

        public UserControlDashboard()
        {
            InitializeComponent();
            genProfit();
            overallSales();
            catchData();
            ordersCompleted();
            topSelling();
        }

        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT prodNo, prodItem, prodQty FROM datainventory ORDER BY prodQty DESC";
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
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void topSelling()
        {
            conn.Close();
            conn.Open();
            string query = "SELECT prodItem, prodBought FROM datainventory ORDER BY prodBought DESC LIMIT 6";
            conn.query(query);
            conn.execute();
            MySqlDataAdapter adapter = conn.adapter();
            DataTable dt = new DataTable("datainventory");
            adapter.Fill(dt);
            listViewRanking.ItemsSource = dt.DefaultView;
            adapter.Update(dt);
            conn.Close();
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
                    tb_profitSales.Text = "₱ " + dr.GetValue(0).ToString();
                    if (tb_profitSales.Text == "₱ .00")
                    {
                        tb_profitSales.Text = "₱ 0.00";
                    }
                }

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
                    if (tb_overallSales.Text == "₱ .00")
                    {
                        tb_overallSales.Text = "₱ 0.00";
                    }
                }
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
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

    }
}
