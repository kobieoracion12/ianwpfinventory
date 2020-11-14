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
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;persistsecurityinfo=True;database=iantestinventory; password='C73DPJxyXICd4Mjq'");

        public UserControlSales()
        {
            InitializeComponent();
            catchData();
            todayInfo();
            salesProfit();
            totalInfo();
        }

        // ListView Data
        private void catchData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Today Sales
        private void todayInfo()
        {
            con.Close();
            try
            {
                string query = "SELECT COUNT(salesTotal) FROM datasalesinventory WHERE DATE(salesDate) = CURDATE()";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_todaySales.Text = "₱" + dr.GetValue(0).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sales Profit 
        private void salesProfit()
        {
            con.Close();
            try
            {
                string query = "SELECT SUM(salesRP-salesSRP) FROM datasalesinventory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_discountSales.Text = "₱" + dr.GetValue(0).ToString();
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Total Sales
        private void totalInfo()
        {
            con.Close();
            try
            {
                string query = "SELECT SUM(salesTotal) FROM datasalesinventory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_overallSales.Text = "₱" + dr.GetValue(0).ToString();
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        //Today Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory WHERE DATE(salesDate) = CURDATE()";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       //This Week Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory WHERE salesDate >= curdate() - INTERVAL DAYOFWEEK(curdate())+6 DAY AND salesDate < curdate() - INTERVAL DAYOFWEEK(curdate())-1 DAY";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Month
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory WHERE MONTH(salesDate) = MONTH(CURRENT_TIMESTAMP) AND YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Last Month Button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory WHERE DATE(salesDate) >= DATE(NOW()) - INTERVAL 30 DAY";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Year
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory WHERE YEAR(salesDate) = YEAR(CURRENT_TIMESTAMP);";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
