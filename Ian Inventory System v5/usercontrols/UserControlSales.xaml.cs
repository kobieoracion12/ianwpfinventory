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
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.windows;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2
{
    public partial class UserControlSales : UserControl
    {
        Database conn = new Database();

        public UserControlSales()
        {
            InitializeComponent();
            catchData();
            todayInfo();
            salesProfit();
            totalInfo();
        }

        // ListView Data
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory";
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
                listViewSales.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Today Sales
        private void todayInfo()
        {
            conn.Close();
            try
            {
                string query = "SELECT COUNT(salesTotal) FROM datasalesinventory WHERE DATE(salesDate) = CURDATE()";
                conn.query(query); // Command Db
                conn.Open();  // Open  Connection

                MySqlDataReader dr = conn.read(); // Execute
                if (dr.Read())
                {
                    tb_todaySales.Text = "₱" + dr.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sales Profit 
        private void salesProfit()
        {
            conn.Close();
            try
            {
                string query = "SELECT SUM(salesRP-salesSRP) FROM datasalesinventory";
                conn.query(query); // Command Db
                conn.Open();  // Open  Connection

                MySqlDataReader dr = conn.read(); // Execute
                if (dr.Read())
                {
                    tb_discountSales.Text = "₱" + dr.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Total Sales
        private void totalInfo()
        {
            conn.Close();
            try
            {
                string query = "SELECT SUM(salesTotal) FROM datasalesinventory";
                conn.query(query); // Command Db
                conn.Open();  // Open  Connection

                MySqlDataReader dr = conn.read(); // Execute
                if (dr.Read())
                {
                    tb_overallSales.Text = "₱" + dr.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        //Today Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            { 
                conn.Open(); // Open Connection
                string query = "SELECT * FROM datasalesinventory WHERE DATE(salesDate) = CURDATE()";
                conn.query(query); // Command Database
                conn.execute(); // ExecuteNonQuery

                MySqlDataAdapter adp = conn.adapter(); // Adapter
                DataTable dt = new DataTable("datasalesinventory"); //  Datatable
                adp.Fill(dt); // Fill the datatable
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                conn.Close(); // Close Connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       //This Week Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open(); // Open Connection
                string query = "SELECT * FROM datasalesinventory WHERE salesDate >= curdate() - INTERVAL DAYOFWEEK(curdate())+6 DAY AND salesDate < curdate() - INTERVAL DAYOFWEEK(curdate())-1 DAY";
                conn.query(query); // Command Database
                conn.execute(); // ExecuteNonQuery

                MySqlDataAdapter adp = conn.adapter(); // Adapter
                DataTable dt = new DataTable("datasalesinventory");  // Datatable
                adp.Fill(dt); // Fill the datatable
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                conn.Close(); // Close Connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Month
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open(); // Open Connection
                string query = "SELECT * FROM datasalesinventory WHERE MONTH(salesDate) = MONTH(CURRENT_TIMESTAMP) AND YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP)";
                conn.query(query); // Command Database
                conn.execute(); // ExecuteNonQuery

                MySqlDataAdapter adp = conn.adapter(); // Adapter
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Last Month Button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open(); // Open Connection
                string query = "SELECT * FROM datasalesinventory WHERE DATE(salesDate) >= DATE(NOW()) - INTERVAL 30 DAY";
                conn.query(query); // Command Database
                conn.execute(); // ExecuteNonQuery

                MySqlDataAdapter adp = conn.adapter(); // Adapter
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                conn.Close(); // Close Connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Year
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open();  // Open Connection
                string query = "SELECT * FROM datasalesinventory WHERE YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP);";
                conn.query(query); // Command Database
                conn.execute(); // ExecuteNonQuery

                MySqlDataAdapter adp = conn.adapter(); // Adapter
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                conn.Close(); // Close Connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
