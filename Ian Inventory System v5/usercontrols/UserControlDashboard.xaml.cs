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
            dailySales();
            weeklySales();
            monthlySales();
            yearlySales();
        }

        // Daily Sales
        private void dailySales()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesTotal) FROM datasalesinventory WHERE DATE(salesDate) = CURDATE()";
            conn.query(query);
            try
            {
                // Open Connection
                conn.Open();
                // Execute 
                MySqlDataReader dr = conn.read();

                if (dr.Read())
                {
                    tb_todaySales.Text = "₱ " + dr.GetValue(0).ToString() + ".00";
                    if (tb_todaySales.Text == "₱ .00")
                    {
                        tb_todaySales.Text = "₱ 0.00";
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

        // Weekly Sales
        private void weeklySales()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesTotal) FROM datasalesinventory WHERE salesDate >= curdate() - INTERVAL DAYOFWEEK(curdate())+6 DAY AND salesDate < curdate() - INTERVAL DAYOFWEEK(curdate())-1 DAY";
            conn.query(query);
            try
            {
                // Open Connection
                conn.Open();
                // Execute 
                MySqlDataReader dr = conn.read();

                if (dr.Read())
                {
                    tb_weeklySales.Text = "₱ " + dr.GetValue(0).ToString() + ".00";
                    if (tb_weeklySales.Text == "₱ .00")
                    {
                        tb_weeklySales.Text = "₱ 0.00";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Montly Sales 
        private void monthlySales()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesTotal) FROM datasalesinventory WHERE MONTH(salesDate) = MONTH(CURRENT_TIMESTAMP) AND YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP)";
            conn.query(query);

            try
            {
                // Open Connection
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    tb_monthlySales.Text = "₱ " + dr.GetValue(0).ToString() + ".00";
                    if (tb_monthlySales.Text == "₱ .00")
                    {
                        tb_monthlySales.Text = "₱ 0.00";
                    }
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Yearly Sales 
        private void yearlySales()
        {
            // Make sure Connection is Closed
            conn.Close();
            //  Command Database
            string query = "SELECT SUM(salesTotal) FROM datasalesinventory WHERE YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP)";
            conn.query(query);

            try
            {
                // Open Connection
                conn.Open();

                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    tb_yearlySales.Text = "₱ " + dr.GetValue(0).ToString() + ".00";
                    if (tb_yearlySales.Text == "₱ .00")
                    {
                        tb_yearlySales.Text = "₱ 0.00";
                    }
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
