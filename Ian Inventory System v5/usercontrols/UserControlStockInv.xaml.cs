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
using NavigationDrawerPopUpMenu2.windows;
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlStockInv : UserControl
    {
        // Init database
        Database conn = new Database();
        public static int prdID;
        public WindowState WindowState { get; private set; }

        public UserControlStockInv()
        {
            InitializeComponent();
            catchData();
            cbContents();
        }

        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datainventory";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            window_addItem addItem = new window_addItem();
            addItem.Show();
        }


        // Copy the id of product when click in listViewInventory cell
        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the product id
                string prodId = listViewInventory.SelectedItems[0].ToString();
                // Append ID and Product name
                tbPrdId.Text = prodId;

            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        // Fills the Brand ComboBox with exisiting Brand Data from Database
        public void cbContents()
        {
            conn.Open();
            try
            {
                string query = "SELECT DISTINCT prodBrand FROM datainventory";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    this.sortBrand.Items.Add(drd.GetString(0).ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            conn.Close();
        }

        private void refreshItem_Click(object sender, RoutedEventArgs e)
        {
            conn.Close();
            catchData();
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            string prdId = tbPrdId.Text;
            if (prdId == "")
            { // Check input if empty
                MessageBox.Show("Please select one on the table cell");
            }
            else
            {   // If not empty then proceed to edit window
                long id = Convert.ToInt64(prdId); // Product Id No. to be pass to other form
                window_editItem editItemWindow = new window_editItem(id); // pass the parameter to the next window
                editItemWindow.Show(); // Open Edit Window}
            }
        }

        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check if field is empty
                MessageBox.Show("Please select one on the table cell");
            }
            else
            {   // Delete the product
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deleteProductItem(); // If Yes then Delete the product
                }
            }
        }

        // Delete Function
        private void deleteProductItem()
        {
            // Delete sql statement
            string sql = "DELETE FROM datainventory WHERE prodNo = @prdNo";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.bind("@prdNo", tbPrdId.Text); // Bind parameter
                conn.cmd().Prepare(); // Prepare
                conn.execute(); // Execute


                MessageBox.Show("Successfully Removed"); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }


        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {

            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            conn.Close();
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datainventory WHERE prodNo LIKE '%" + tbSearch.Text + "%' OR prodItem LIKE '%" + tbSearch.Text + "%' OR prodBrand LIKE '%" + tbSearch.Text + "%' OR prodSRP LIKE '%" + tbSearch.Text + "%' OR prodRP LIKE '%" + tbSearch.Text + "%'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();
                // Empty the search box
                tbSearch.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sortRestock_Click(object sender, RoutedEventArgs e)
        {
            window_restockItem restockItem = new window_restockItem();
            restockItem.ShowDialog();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            string brandSort = sortBrand.Text;
            if (brandSort == "Select")
            {
                brandSort = null;
            }

            conn.Close();
            try
            {
                conn.Open();
                string query = "SELECT * FROM datainventory WHERE prodBrand LIKE '%" + brandSort + "%'";
                conn.query(query);
                conn.execute();
                MySqlDataAdapter adapter = conn.adapter();
                DataTable dt = new DataTable("datainventory");
                adapter.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
