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
    public partial class window_restockItem : Window
    {
        Database conn = new Database();
        public window_restockItem()
        {
            InitializeComponent();
        }

        // Barcode Scanner
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;
                string scan = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodDOA, prodEXPD FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(scan);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        restockItem.Text = row[0]; 
                        restockBrand.Text = row[1]; 
                        onrestockQty.Text = row[2]; 
                        restockSRP.Text = row[4];
                        restockRP.Text = row[5];
                        restockDOA.Text = row[6]; 
                        restockEXPD.Text = row[7]; 
                    }
                    else

                    {
                        MessageBox.Show("Error");
                        entrySearch.Text = "";
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                conn.Close();
            }
            else
            {
                return;
            }
        }


        private void submitBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string restock = "UPDATE datainventory SET prodItem = @Itm, prodBrand = @Brnd, prodItem = @Itm, prodQty = @Qty, prodSRP = @SRP, prodRP = @RP, prodDOA = @DOA, prodEXPD = @EXPD WHERE prodNo = @No";
                conn.query(restock);

                try
                {
                    conn.Open();
                    conn.bind("@No", entrySearch.Text);
                    conn.bind("@Itm", restockItem.Text);
                    conn.bind("@Brnd", restockBrand.Text);
                    conn.bind("@Qty", restockQty.Text);
                    conn.bind("@SRP", restockSRP.Text);
                    conn.bind("@RP", restockRP.Text);
                    conn.bind("@DOA", DateTime.Now);

                    string date = restockEXPD.Text;
                    DateTime dateTime;
                    dateTime = DateTime.Parse(date);
                    conn.bind("@EXPD", dateTime);
                    var check = conn.execute();
                    if (check == 1)
                    {
                        MessageBox.Show("Data Updated!");
                        restockItem.Text = "";
                        restockBrand.Text = "";
                        restockQty.Text = "";
                        restockSRP.Text = "";
                        restockRP.Text = "";
                        restockDOA.Text = "";
                        restockEXPD.Text = "";
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        private void submitCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
