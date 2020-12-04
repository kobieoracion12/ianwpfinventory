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
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_add_item : Window
    {
        Database con = new Database();
        Checkout checkout = new Checkout();

        win_pos win_pos;
        public win_add_item(win_pos winPOS)
        {
            InitializeComponent();
            win_pos = winPOS;
            checkBarcode.Focus();
            cbBrand();
           
        }

        // Barcode Scanner Function
        private void checkBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string search = checkBarcode.Text;
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
                            var ans = MessageBox.Show("Item Already Exist");
                            Clear();
                            con.Close();
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

        // Clear Function
        public void Clear()
        {
            checkBarcode.Focus();
            checkBarcode.Clear();
            addItem.Clear();
            addRP.Clear();
            addSRP.Clear();
        }

        // Submit Button
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (addItem.Text == "" || addBrand.Text == "" || addSRP.Text == "" || addRP.Text == "Select" || addDOA.Text == "" || addEXPD.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                try
                {
                    con.Open();
                    string itemInsert = "INSERT INTO cashierinventory (itemNo, itemName, itemBrand, itemRP, itemSRP, itemDOA, itemEXPD, cashierName, cashierNo, itemStatus) VALUES (@no, @item, @brand, @rp, @srp, @doa, @expd, @cname, @cno, @status);";
                    con.query(itemInsert);

                    con.bind("@no", checkBarcode.Text);
                    con.bind("@item", addItem.Text);
                    con.bind("@brand", addBrand.Text);
                    con.bind("@rp", addRP.Text);
                    con.bind("@srp", addSRP.Text);
                    con.bind("@cname", win_pos.cashierName.Text); // ROBERT
                    con.bind("@cno", win_pos.accNo.Text); // ROBERT
                    con.bind("@status", "Pending");

                    string str = addEXPD.Text;
                    DateTime dt = DateTime.Parse(str);

                    con.bind("@doa", DateTime.Now);
                    con.bind("@expd", dt);

                    con.cmd().Prepare();
                    int a = con.execute();
                    if (a == 1)
                    {
                        MessageBox.Show("Item will be subject of approval", "Success");
                        cbBrand();
                        checkBarcode.Focus();
                        Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + ", Try again later", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    con.Close();
                }
            }
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
                    this.addBrand.Items.Add(drd.GetString(0).ToString());
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

        // Cancel Button
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
