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
                string scan = "SELECT prodItem, prodBrand, prodQty, prodSRP, prodRP, prodVAT, prodDOA FROM datainventory WHERE prodNo= '" + search + "'";
                conn.query(scan);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                        restockItem.Text = row[0];
                        restockBrand.Text = row[1];
                        onrestockQty.Text = row[2];
                        restockSRP.Text = row[3];
                        restockRP.Text = row[4];
                        restockVAT.Text = row[5];
                        restockDOA.Text = row[6];

                        restockQty.Focus();
                    }
                    else

                    {
                        MessageBox.Show("Item not Found");
                        entrySearch.Text = "";
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
        }

        // Submit Button
        private void submitBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = int.Parse(onrestockQty.Text);
                int toRestock = int.Parse(restockQty.Text);

                int toRestockTotal = (current + toRestock);

                string restock = "UPDATE datainventory SET prodQty = @Qty WHERE prodNo = @No";
                conn.query(restock);

                try
                {
                    conn.Open();
                    conn.bind("@No", entrySearch.Text);
                    conn.bind("@Qty", toRestockTotal);

                    var check = conn.execute();
                    if (check == 1)
                    {
                        MessageBox.Show("Data Updated!");
                        entrySearch.Clear();
                        entrySearch.Focus();
                        restockItem.Clear();
                        restockBrand.Clear();
                        restockQty.Clear();
                        restockSRP.Clear();
                        restockRP.Clear();
                        restockVAT.Clear();
                        onrestockQty.Clear();
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

        // Cancel Button
        private void submitCancel_Click(object sender, RoutedEventArgs e)
        {
            usc_inventory ui = new usc_inventory();
            usc_parent_overview upo = new usc_parent_overview();
            ui.mainSubColumn.Children.Add(upo);
        }
    }
}
