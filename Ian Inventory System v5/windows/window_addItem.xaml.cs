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
using NavigationDrawerPopUpMenu2;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class window_addItem : Window
    {
        Database con = new Database();
        public window_addItem()
        {
            InitializeComponent();
            cbBrand();
            tbProdNo.Focus();
        }

        // Barcode Scan
        private void tbProdNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string search = tbProdNo.Text;
                string scan = "SELECT prodNo FROM datainventory WHERE prodNo= '" + search + "'";
                con.query(scan);
                try
                {
                    con.Open();
                    MySqlDataReader reader = con.read();
                    if (reader.Read())
                    {
                        string[] row = { reader.GetString(0) };
                        checker.Text = row[0];
                        if (checker.Text == search)
                        {
                            var ans = MessageBox.Show("Do you want to restock this item?", "Item Already Exist", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            if (ans == MessageBoxResult.Yes)
                            {
                                window_restockItem wit = new window_restockItem();
                                wit.ShowDialog();
                                Clear();
                            }
                            else
                            {
                                con.Close();
                                Clear();
                            }
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                    con.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Submit Button
        private void addItemSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (tbProdNo.Text == "" || tbProdItem.Text == "" || tbProdBrand.Text == "" || tbProdBrand.Text == "Select" || tbProdQty.Text == "" || tbProdSRP.Text == "" || tbProdRP.Text == "" || tbProdDOA.Text == "" || tbProdEXPD.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                try
                {
                    con.Open();
                    string itemInsert = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodQty, prodSRP, prodRP, prodDOA, prodEXPD) VALUES (@pn, @pi, @pb, @py, @pp, @pq, @pdoa, @pexpd);";
                    con.query(itemInsert);

                    con.bind("@pn", tbProdNo.Text);
                    con.bind("@pi", tbProdItem.Text);
                    con.bind("@pb", tbProdBrand.Text);
                    con.bind("@py", tbProdQty.Text);
                    con.bind("@pp", tbProdSRP.Text);
                    con.bind("@pq", tbProdRP.Text);

                    string str = tbProdEXPD.Text;
                    DateTime dt = DateTime.Parse(str);

                    con.bind("@pdoa", DateTime.Now);
                    con.bind("@pexpd", dt);

                    con.cmd().Prepare();
                    int a = con.execute();
                    if (a == 1)
                    {
                        MessageBox.Show("Data added Sucessfully");
                        cbBrand();
                        tbProdNo.Focus();
                        Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Cancel Function
        private void addItemCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Clear Function
        public void Clear()
        {
            tbProdNo.Text = "";
            tbProdItem.Text = "";
            tbProdBrand.Text = "Select";
            tbProdQty.Text = "";
            tbProdSRP.Text = "";
            tbProdRP.Text = "";
            tbProdEXPD.Text = "";
        }

        // Populate Brand Combobox
        public void cbBrand()
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT DISTINCT prodBrand FROM datainventory";
                con.query(query);
                con.execute();
                MySqlDataReader drd = con.read();

                while (drd.Read())
                {
                    this.tbProdBrand.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

    }
}
