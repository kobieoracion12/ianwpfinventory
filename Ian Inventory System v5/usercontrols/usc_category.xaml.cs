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
    public partial class usc_category : UserControl
    {
        Database conn = new Database();
        public WindowState WindowState { get; private set; }

        public usc_category()
        {
            InitializeComponent();
            fetchCategory();
        }

        // Fetch Data from database
        public void fetchCategoryForOtherForm()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT DISTINCT category_name FROM category ORDER BY category_name ASC";
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
                listViewCategory.ItemsSource = dt.DefaultView;
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

        public void fetchCategory()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT DISTINCT category_name FROM category ORDER BY category_name ASC";
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
                listViewCategory.ItemsSource = dt.DefaultView;
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

        // Fills the second listView with the selected category
        private void itemCtg_TextChanged(object sender, TextChangedEventArgs e)
        {
            conn.Close();
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT prodNo, prodItem, prodBrand, prodCategory FROM datainventory WHERE prodCategory LIKE '%" + itemCtg.Text + "%' ORDER BY prodItem ASC";
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
                listViewBrowse.ItemsSource = dt.DefaultView;
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

        // Add Button
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            win_add_category addCategoryWin = new win_add_category(this);
            addCategoryWin.ShowDialog();
        }

        // Edit Button
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (itemCtg.Text == "")
            { // Check input if empty
                MessageBox.Show("No selected category", "Edit Category", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // If not empty then proceed to edit window
                win_edit_category win_edit_category = new win_edit_category(this); // pass the parameter to the next window
                win_edit_category.ShowDialog(); // Open Edit Window}
            }
        }

        // Delete Button
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (itemCtg.Text == "")
            { // Check if field is empty
                MessageBox.Show("No Selected Category", "Remove Category", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // Delete the product
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deleteCategory(); // If Yes then Delete the product
                    fetchCategory();
                }
            }
        }

        // Delete Function
        private void deleteCategory()
        {
            // Delete sql statement
            string sql = "DELETE FROM category WHERE category_name = @cId";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.bind("@cId", itemCtg.Text); // Bind parameter
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

        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            conn.Close();
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT category_name FROM category WHERE category_name LIKE '%" + entrySearch.Text + "%' ORDER BY category_name ASC";
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
                listViewCategory.ItemsSource = dt.DefaultView;
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

        // Pass Data to TxtBox
        private void listViewCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // Get the product id
                string category = listViewCategory.SelectedItems[1].ToString();
                //itemCtg.Text = name;
                MessageBox.Show(category);
            }
            catch (Exception ex)
            { return; }
        }
    }
}
