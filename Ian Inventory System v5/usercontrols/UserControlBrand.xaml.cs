using NavigationDrawerPopUpMenu2.classes;
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
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    /// <summary>
    /// Interaction logic for UserControlBrand.xaml
    /// </summary>
    public partial class UserControlBrand : UserControl
    {
        Database conn = new Database();
        public UserControlBrand()
        {
            InitializeComponent();
            catchData();
        }

        // Pass Data to ListView
        private void listViewInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // Get the product id
                string prodId = listViewInventory.SelectedItems[0].ToString();
                // Append ID and Product name
                tbPrdId.Text = prodId;

            }
            catch (Exception ex)
            {
                return;
            }
        }

        // Load Data
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM brand";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("brand");
                // Fill the datatable
                adapter.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Search Data
        private void searchCategory()
        {
            conn.Close(); // Close the connection first
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM brand WHERE bId LIKE '%" + tbSearch.Text + "%' OR brand_name LIKE '%" + tbSearch.Text + "%' ";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("brand");
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
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Refresh
        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            catchData();
            tbSearch.Text = "";
        }

        // Clear All
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (MessageBox.Show("This will clear all your brand?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    clearAllCategory(); // If Yes then Delete the product
                    catchData();
                }
            }
        }

        // Clear All Function
        public void clearAllCategory()
        {
            // Delete sql statement
            string sql = "DELETE FROM brand";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.execute(); // Execute


                MessageBox.Show("All brand has been removed"); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                conn.Close();
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        // Remove Button
        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check if field is empty
                MessageBox.Show("No Selected Brand", "Remove Brand", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // Delete the product
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deleteCategory(); // If Yes then Delete the product
                    catchData();
                }
            }
        }

        // Remove Function
        private void deleteCategory()
        {
            // Delete sql statement
            string sql = "DELETE FROM category WHERE bId = @bId";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.bind("@bId", tbPrdId.Text); // Bind parameter
                conn.cmd().Prepare(); // Prepare
                conn.execute(); // Execute


                MessageBox.Show("Successfully Removed", "Brand Removed", MessageBoxButton.OK, MessageBoxImage.Information); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                conn.Close();
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        // Add Brand
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            win_add_brand addbrand = new win_add_brand(this);
            addbrand.ShowDialog();
        }

        // Edit Button
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check input if empty
                MessageBox.Show("No selected Brand", "Edit Category", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // If not empty then proceed to edit window
                win_edit_brand win_edit_brand = new win_edit_brand(this); // pass the parameter to the next window
                win_edit_brand.ShowDialog(); // Open Edit Window}
            }
        }

        
    }
}
