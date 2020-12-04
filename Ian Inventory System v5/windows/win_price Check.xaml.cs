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
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_priceCheck : Window
    {
        Database conn = new Database();
        public win_priceCheck()
        {
            InitializeComponent();
            checkBarcode.Focus();
        }

        // Barcode Function
        private void checkBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            conn.Close();
            if (e.Key == Key.Return)
            {
                string search = checkBarcode.Text;
                string scan = "SELECT prodItem, prodBrand, prodQty, prodRP, prodDOA FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(scan);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        checkItem.Text = row[0];
                        checkBrand.Text = row[1];
                        checkStock.Text = row[2];
                        checkPrice.Text = row[3];
                        checkDOA.Text = row[4];

                        // Convert Stock Status to Labels
                        int status = Convert.ToInt32(checkStock.Text);
                        if (status == 0)
                        {
                            checkStatus.Text = "Out of Stock";
                            checkStatus.Foreground = Brushes.Red;
                        }
                        else if (status >= 1 && status <= 10)
                        {
                            checkStatus.Text = "Running of Stock";
                            checkStatus.Foreground = Brushes.Orange;
                        }

                        else if (status >= 11)
                        {
                            checkStatus.Text = "Good";
                            checkStatus.Foreground = Brushes.Green;
                        }
                        checkBarcode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Item Not Found!");
                        Clear();
                    }

                    reader.Close();
                    reader.Dispose();
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                return;
            }
            conn.Close();
        }

        // Return Button
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Clear Textboxes
        public void Clear()
        {
            checkItem.Clear();
            checkBrand.Clear();
            checkStock.Clear();
            checkPrice.Clear();
            checkDOA.Clear();
            checkStatus.Clear();
            checkBarcode.Clear();
            checkBarcode.Focus();
        }
    }
}
