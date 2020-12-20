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
using NavigationDrawerPopUpMenu2.reports;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_parent_overviews : UserControl
    {
        Database conn = new Database();
        public static int prdID;
        public string filter = "Select";
        public WindowState WindowState { get; private set; }

        public usc_parent_overviews()
        {
            InitializeComponent();
            catchData();
            cbBrand();
            cbCategory();
            getLastDate();
        }

        // Populate ListView
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datainventory ORDER BY prodItem ASC";
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

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fills the Brand ComboBox with exisiting Brand Data from Database
        public void cbBrand()
        {
            conn.Open();
            try
            {
                string query = "SELECT DISTINCT prodBrand FROM datainventory ORDER BY prodBrand ASC";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    this.sortBrand.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        // Fills the Brand ComboBox with exisiting Category Data from Database
        public void cbCategory()
        {
            conn.Open();
            try
            {
                string query = "SELECT category_name FROM category ORDER BY category_name ASC";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    sortCategory.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

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

        // Edit Button
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            string prdId = tbPrdId.Text;
            if (prdId == "")
            { // Check input if empty
                MessageBox.Show("Please select one on the table cell", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // If not empty then proceed to edit window
                long id = Convert.ToInt64(prdId); // Product Id No. to be pass to other form
                window_editItem editItemWindow = new window_editItem(id); // pass the parameter to the next window
                editItemWindow.Show(); // Open Edit Window}
            }
        }

        // Remove Button
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check if field is empty
                MessageBox.Show("Please select one on the table cell", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        // Fill the DatePicker with the first date available in database
        public void getLastDate()
        {
            try
            {
                conn.Open();
                string lastDate = "SELECT prodDOA FROM datainventory ORDER BY prodDOA ASC LIMIT 1";
                conn.query(lastDate);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    string[] row = { drd.GetString(0) };
                    sortDOAfrom.Text = row[0];
                }

                drd.Close();
                drd.Dispose();
                conn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Sort Button
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            filter = "Sort";
            string doaFrom, doaTo, brand, category;
            // Init selected dates from calendar
            DateTime? selectedDateFrom = sortDOAfrom.SelectedDate;
            DateTime? selectedDateTo = sortDOAto.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                // Making a format and getting the value of datepicker to string
                doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                brand = sortBrand.Text;
                category = sortCategory.Text;
                if (brand == "Select")
                {
                    brand = null;
                }
                else if (category == "Select")
                {
                    category = null;
                }
                try
                {
                    conn.Open(); // Open Connection
                    string query = "SELECT * FROM datainventory WHERE prodBrand LIKE '%" + brand + "%' AND prodCategory LIKE '%" + category + "%' AND prodDOA BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY prodItem ASC "; // Sort base on the query
                    conn.query(query);  // Command Database
                    conn.execute(); // Execute Non Query
                    MySqlDataAdapter adapter = conn.adapter(); // adapter
                    System.Data.DataTable dt = new System.Data.DataTable("datasalesinventory"); // Make a datatable reference
                    adapter.Fill(dt);  // Fill the datatable with data
                    listViewInventory.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);

                    adapter.Dispose(); // Dispose Adapter
                    conn.Close(); // Close Connection
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Refresh Button
        private void refreshItem_Click(object sender, RoutedEventArgs e)
        {
            catchData();
            sortBrand.Text = "Select";
            sortCategory.Text = "Select";
            filter = "Select";
        }

        // Search Function
        private void searchSort_TextChanged(object sender, TextChangedEventArgs e)
        {
            conn.Close(); // Close the connection first
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datainventory WHERE prodNo LIKE '%" + tbSearch.Text + "%' OR prodItem LIKE '%" + tbSearch.Text + "%' OR prodBrand LIKE '%" + tbSearch.Text + "%' OR prodSRP LIKE '%" + tbSearch.Text + "%' OR prodRP LIKE '%" + tbSearch.Text + "%' ORDER BY prodItem ASC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                System.Data.DataTable dt = new System.Data.DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Print Button
        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            report_inventory rprtinv = new report_inventory(this);
            rprtinv.printPreview();
            rprtinv.ShowDialog();
        }
    }
}
