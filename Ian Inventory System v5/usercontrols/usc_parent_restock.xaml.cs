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
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_parent_restock : UserControl
    {
        Database conn = new Database();
        bool found = false;
        public usc_parent_restock()
        {
            InitializeComponent();
            entrySearch.Focus();
        }

        // Barcode Scanner
        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string search = entrySearch.Text;
                string scan = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodCategory, prodVAT, prodDOA FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(scan);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.Read())
                    {
                        found = true;
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        restockItem.Text = row[0];
                        restockBrand.Text = row[1];
                        onrestockQty.Text = row[2];
                        restockSRP.Text = row[3];
                        restockRP.Text = row[4];
                        restockCategory.Text = row[5];
                        restockVAT.Text = row[6];
                        restockDOA.Text = row[7];
                        restockQty.Focus();
                    }
                    else
                    {
                        found = false;
                        MessageBox.Show("Item not found", "Restock", MessageBoxButton.OK, MessageBoxImage.Warning);
                        entrySearch.Text = "";
                    }

                    reader.Close();
                    reader.Dispose();
                    conn.Close();
                    ////

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Restock", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                return;
            }
        }

        // Submit Button
        private void submitBrand_Click(object sender, RoutedEventArgs e)
        {
            // If item NOT found
            if (!found)
            {
                MessageBox.Show("Item not found", "Restock", MessageBoxButton.OK, MessageBoxImage.Warning);
                entrySearch.Text = "";
            }
            else
            {
                string restock = "UPDATE datainventory SET prodQty = (prodQty + @Qty) WHERE prodNo = @No";
                conn.query(restock);

                try
                {
                    conn.Open();
                    conn.bind("@No", entrySearch.Text);
                    conn.bind("@Qty", restockQty.Text);

                    var check = conn.execute();
                    if (check == 1)
                    {
                        MessageBox.Show("Data Updated!", "Restock", MessageBoxButton.OK, MessageBoxImage.Information);
                        entrySearch.Clear();
                        entrySearch.Focus();
                        restockItem.Clear();
                        restockBrand.Clear();
                        restockQty.Clear();
                        restockSRP.Clear();
                        restockRP.Clear();
                        restockCategory.Clear();
                        restockVAT.Clear();
                        onrestockQty.Clear();
                        restockDOA.Text = "";
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Restock", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
        }

        // Cancel Button
        private void submitCancel_Click(object sender, RoutedEventArgs e)
        {
            usc_inventory ui = new usc_inventory();
            usc_parent_overviews upo = new usc_parent_overviews();
            ui.mainSubColumn.Children.Add(upo);
        }
    }
}
