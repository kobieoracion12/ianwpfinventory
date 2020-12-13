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

namespace NavigationDrawerPopUpMenu2
{
    
    public partial class UserControlInventory : UserControl
    {
        // Init database
        Database conn = new Database();
        public static int prdID;
        public WindowState WindowState { get; private set; }

        public UserControlInventory()
        {
            InitializeComponent();
            catchData();
        }

        // Show Data
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM category";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("category");
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
            catch (Exception ex)
            {
                return;
            }
        }

        // Add Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            win_add_category addCateg = new win_add_category(this);
            addCateg.ShowDialog();
        }

        // Refresh Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            conn.Close();
            catchData();
        }

        // Edit Button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check input if empty
                MessageBox.Show("No selected category", "Edit Category", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // If not empty then proceed to edit window
                win_edit_category win_edit_category = new win_edit_category(this); // pass the parameter to the next window
                win_edit_category.ShowDialog(); // Open Edit Window}
            }
        }

        private void listViewInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Delete Button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check if field is empty
                MessageBox.Show("No Selected Category", "Remove Category", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        // Delete Function
        private void deleteCategory()
        {
            // Delete sql statement
            string sql = "DELETE FROM category WHERE cId = @cId";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.bind("@cId", tbPrdId.Text); // Bind parameter
                conn.cmd().Prepare(); // Prepare
                conn.execute(); // Execute
                
                 
                MessageBox.Show("Successfully Removed", "Category Removed", MessageBoxButton.OK, MessageBoxImage.Information); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                conn.Close();
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        // RealTime Search
        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Search Function 
        private void searchCategory() {
            conn.Close(); // Close the connection first
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM category WHERE cId LIKE '%" + tbSearch.Text + "%' OR category_name LIKE '%" + tbSearch.Text + "%' ";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("category");
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

        // Search Button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            searchCategory();
        }

        // When the window loads
        private void UserControlInventory_Loaded_1(object sender, RoutedEventArgs e)
        {
            conn.Close(); // Close all connections
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            window_restockItem restockItem = new window_restockItem();
            restockItem.ShowDialog();
        }

        // Clear All Category
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
                if (MessageBox.Show("Are you sure you want to remove all?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (MessageBox.Show("This will clear all your categories?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        clearAllCategory(); // If Yes then Delete the product
                        catchData();
                    }
                }
        }

        // Clear All
        public void clearAllCategory()
        {
            // Delete sql statement
            string sql = "DELETE FROM category";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.execute(); // Execute


                MessageBox.Show("All category has been removed"); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                conn.Close();
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
    }
}
