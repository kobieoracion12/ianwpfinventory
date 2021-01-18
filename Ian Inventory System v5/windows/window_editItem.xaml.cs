﻿using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;
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
        public window_editItem(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public string Value { get; set; } // Create a variable to store the value

        // When the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   // show the value to the textbox
            editProdNo.Text = Value.ToString();
            // Append the data in the textboxes to be edited.
            catchData();
            cbBrand();
            cbCatergory();
        }

        // Select Data the Edit
        public void catchData()
        {
            string prdNo = editProdNo.Text; // Product Number
            string sql = "SELECT prodNo, prodItem, prodBrand, prodSRP, prodRP, prodVAT, prodCategory FROM datainventory WHERE prodNo = '" + prdNo + "'"; // Sql Statement 
            conn.query(sql); // Command Database
            
            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                    editProdNo.Text = row[0]; 
                    editProdItem.Text = row[1]; 
                    editProdBrand.Text = row[2]; 
                    editProdSRP.Text = row[3]; 
                    editProdRP.Text = row[4];
                    editProdVAT.Text = row[5];
                    editProdCategory.Text = row[6];

                    double catchVAT = (double.Parse(editProdVAT.Text) * 100);
                    editProdVAT.Text = Convert.ToString(catchVAT);

                    if (editProdCategory.Text == "")
                    {
                        editProdCategory.Text = "Select";
                    }
                }

                reader.Close();
                reader.Dispose();
                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
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
            string prdVAT = editProdVAT.Text; // Product VAT

            // Check if fields are empty
            if (prdNo == "" || prdItem == "" || prdBrand == "" || prdSRP == "" || prdRP == "" || prdVAT == "")
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
            if (prdBrand == "Select")
            {
                prdBrand = null;
            }
            string prdSRP = editProdSRP.Text; // Product SRP
            string prdRP = editProdRP.Text; // Product RP
            string prdVAT = editProdVAT.Text; // Product VAT
            string prdCateg = editProdCategory.Text;
            if (prdCateg == "Select")
            {
                prdCateg = null;
            }

            double getVAT = (double.Parse(editProdVAT.Text) / 100);

            if (getVAT > 100 || getVAT < 0)
            {
                MessageBox.Show("Choose between 0-100 only", "Error");
            }
            else
            {
                // Sql Statement
                string sql = "UPDATE datainventory SET prodItem = @prdItem, prodBrand = @prdBrand, prodSRP = @prdSRP, prodRP = @prdRP, prodVAT = @prdVAT, prodCategory = @prdCateg WHERE prodNo = @prdNo ";
                conn.Close();
                try
                {
                    conn.Open();  // Open Connection

                    conn.query(sql); // Command Database

                    conn.bind("@prdItem", prdItem); // Bind parameters with values
                    conn.bind("@prdBrand", prdBrand);
                    conn.bind("@prdSRP", prdSRP);
                    conn.bind("@prdRP", prdRP);
                    conn.bind("@prdVAT", getVAT);
                    conn.bind("@prdCateg", prdCateg);
                    conn.bind("@prdNo", editProdNo.Text);

                    conn.cmd().Prepare(); // Prepare
                    conn.execute(); // ExecuteNonQuery

                    MessageBox.Show("Successfully Updated"); // Show Dialog Succes

                    conn.Close(); // Close Connection
                    Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        // Close the window 
        private void editCancel_Click(object sender, RoutedEventArgs e)
        { 
            Close();
        }

        // Catch Brands
        public void cbBrand()
        {
            conn.Close();
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT prodBrand FROM datainventory ORDER BY prodBrand ASC";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    editProdBrand.Items.Add(drd.GetString(0).ToString());
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

        // Catch Category
        public void cbCatergory()
        {
            conn.Close();
            try
            {
                conn.Open();
                string asd = "SELECT DISTINCT category_name FROM category ORDER BY category_name ASC";
                conn.query(asd);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    editProdCategory.Items.Add(drd.GetString(0).ToString());
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

        // Prevent User to type Letters
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var editProdRP = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = editProdRP.Text.Insert(editProdRP.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }
        private void TextBoxSRP_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var editProdSRP = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = editProdSRP.Text.Insert(editProdSRP.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }
    }
}
