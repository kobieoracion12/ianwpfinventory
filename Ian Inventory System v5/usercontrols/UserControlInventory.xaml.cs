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
        public static int prdID;
        public WindowState WindowState { get; private set; }

        public UserControlInventory()
        {
            InitializeComponent();
            catchData();
        }

        // Init database
        Database conn = new Database();
        
        // Show Data
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
            catch (ArgumentOutOfRangeException ex)
            {
                return;
            }
        }

        // Add Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window_addItem addItem = new window_addItem();
            addItem.Show();
        }

        // Refresh Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            catchData();
        }

        // Edit Button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {   
            long id = Convert.ToInt64(tbPrdId.Text); // Product Id No. to be pass to other form
            window_editItem editItemWindow = new window_editItem(id); // pass the parameter to the next window
            editItemWindow.Show(); // Open Edit Window
        }

        private void listViewInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Delete Button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Delete the product
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {   
                deleteProductItem(); // If Yes then Delete the product
            } 

        }

        // Delete Function
        private void deleteProductItem()
        {
            // Delete sql statement
            int id = Convert.ToInt32(tbPrdId.Text);
            string sql = "DELETE FROM datainventory WHERE prodNo = '" + id + "'";
            conn.query(sql); // Command Database

            try
            {
                conn.Open();   // Open Connection
                conn.read(); // Execute 
                MessageBox.Show("Successfully Removed"); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
