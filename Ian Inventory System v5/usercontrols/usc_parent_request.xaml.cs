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
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_parent_request : UserControl
    {
        Database conn = new Database();
        public usc_parent_request()
        {
            InitializeComponent();
            fetchCashier();
        }

        // Fetch cashiers from cashierinventory
        public void fetchCashier()
        {
            conn.Open();
            string cashier = "SELECT DISTINCT cashierName FROM cashierinventory";
            try
            {
                conn.query(cashier);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    sortCashier.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        public void fetchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT itemNo, itemName FROM cashierinventory WHERE itemStatus = 'Pending'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("cashierinventory");
                // Fill the datatable
                adapter.Fill(dt);
                lv_browse.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Select Cashier Button
        private void selectCashier_Click(object sender, RoutedEventArgs e)
        {
            fetchData();
        }

        // Copy the id of product when click in lv_browse cell
        private void lv_browse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the product id
                string prodId = lv_browse.SelectedItems[0].ToString();
                // Append ID and Product name
                itemNo.Text = prodId;

            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }


        }

        // Populate textbox according to the product id
        private void itemNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                conn.Close();
                if (itemNo.Text.Length > 0)
                {
                    string search = itemNo.Text;
                    string query = "SELECT itemNo, itemName, itemBrand, itemRP, itemSRP, itemVAT, itemCategory FROM cashierinventory WHERE itemNo = '" + search + "'";
                    conn.query(query); //CMD 
                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.Read())
                    {
                        itemNo.Text = dr.GetValue(0).ToString();
                        itemName.Text = dr.GetValue(1).ToString();
                        itemBrand.Text = dr.GetValue(2).ToString();
                        itemRP.Text = dr.GetValue(3).ToString();
                        itemSRP.Text = dr.GetValue(4).ToString();
                        itemVAT.Text = dr.GetValue(5).ToString();
                        itemCategory.Text = dr.GetValue(6).ToString();
                        dr.Close();
                        dr.Dispose(); // Dispose
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                    dr.Close();
                    dr.Dispose();
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Approve Button
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            try
            {
                string addRequest = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodSRP, prodRP, prodVAT, prodDOA) VALUES (@no, @item, @brand, @srp, @rp, @vat, @doa)";
                conn.query(addRequest);

                conn.bind("@no", itemNo.Text);
                conn.bind("@item", itemName.Text);
                conn.bind("@brand", itemBrand.Text);
                conn.bind("@srp", itemSRP.Text);
                conn.bind("@rp", itemRP.Text);
                conn.bind("vat", itemVAT.Text);
                conn.bind("@doa", DateTime.Now);
                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("Item Added!");
                    try
                    {
                        string itemStatus = "UPDATE cashierinventory SET itemStatus = 'Approved' WHERE itemNo = @item";
                        conn.query(itemStatus);
                        conn.bind("@item", itemNo.Text);
                        conn.execute();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                Clear();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Clear Function
        public void Clear()
        {
            itemNo.Clear();
            itemName.Clear();
            itemBrand.Clear();
            itemSRP.Clear();
            itemRP.Clear();
            itemVAT.Clear();
            itemCategory.Clear();
            fetchData();
        }
    }
}
