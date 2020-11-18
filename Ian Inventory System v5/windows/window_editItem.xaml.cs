using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;
using System.Data;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class window_editItem : Window
    {

        public window_editItem()
        {
            InitializeComponent();
        }

        Database conn = new Database(); // Init Database

        // Create a constructor overload to hold and pass the data
        public window_editItem(long value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public long Value { get; set; } // Create a variable to store the value

        // When the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   // show the value to the textbox
            editProdNo.Text = Value.ToString();
            // Append the data in the textboxes to be edited.
            catchData();
        }

        // Select Data the Edit
        public void catchData()
        {
            long prdNo = Convert.ToInt64(editProdNo.Text); // Product Number
            string sql = "SELECT * FROM datainventory WHERE prodNo = '" + prdNo + "'"; // Sql Statement 
            conn.query(sql); // Command Database
            
            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    //  0 = Product No, 1 = ProdItem, 2 = ProdBrand, 3 = ProdSRP, 4 = ProdRP, 5 =  prodDOA, 6 = ProdEXPD
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                    editProdNo.Text = row[0]; // Product No
                    editProdItem.Text = row[1]; // Product Item
                    editProdBrand.Text = row[2]; // Product Brand
                    editProdSRP.Text = row[4]; // Product SRP
                    editProdRP.Text = row[5]; // Product RP
                }

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Edit Button
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            string prdNo = editProdNo.Text; // Product No
            string prdItem = editProdItem.Text; // Product Item
            string prdBrand = editProdBrand.Text; // Product Brand
            string prdSRP = editProdSRP.Text; // Product SRP
            string prdRP = editProdRP.Text; // Product RP

            // Check if fields are empty
            if (prdNo == "" || prdItem == "" || prdBrand == "" || prdSRP == "" || prdRP == "")
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
            { // Delete the product
                if (MessageBox.Show("Are you sure you want to edit this product?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    editProductItem(); // If Yes then Update the product
                }
            }     
        }

        // Edit Function
        private void editProductItem() {
            long prdNo = Convert.ToInt64(editProdNo.Text); // Product No
            string prdItem = editProdItem.Text; // Product Item
            string prdBrand = editProdBrand.Text; // Product Brand
            string prdSRP = editProdSRP.Text; // Product SRP
            string prdRP = editProdRP.Text; // Product RP

            // Sql Statement
            string sql = "UPDATE datainventory SET prodItem = @prdItem, prodBrand = @prdBrand, prodSRP = @prdSRP, prodRP = @prdRP WHERE prodNo = @prdNo ";
            
            try
            {
                conn.Open();  // Open Connection

                conn.query(sql); // Command Database

                conn.bind("@prdItem", prdItem); // Bind parameters with values
                conn.bind("@prdBrand", prdBrand);
                conn.bind("@prdSRP", prdSRP);
                conn.bind("@prdRP", prdRP);
                conn.bind("@prdNo", editProdNo.Text);
 
                conn.cmd().Prepare(); // Prepare
                conn.execute(); // ExecuteNonQuery

                MessageBox.Show("Successfully Updated"); // Show Dialog Succes

                conn.Close(); // Close Connection

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        // Close the window 
        private void editCancel_Click(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }
    }
}
