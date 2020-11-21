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
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlCheckout : UserControl
    {
        Database conn = new Database();
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");

        public UserControlCheckout()
        {
            InitializeComponent();
        }

        public UserControlCheckout(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public string Value { get; set; } // Create a variable to store the value


        // When Checkout loads
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            window_cashButton.myCash = cashAmount.Text;
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }


        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            cashAmount.Text = "₱ " + msg;
            pay_paid.Text = "₱ " + msg;
        }


        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            con.Close();
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;

                DataTable dt = new DataTable();
                con.Open();
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand("SELECT prodItem, prodBrand, prodRP FROM datainventory WHERE prodNo= '" + search + "'", con);

                myReader = myCommand.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        coItem.Text = (myReader["prodItem"].ToString());
                        coBrand.Text = (myReader["prodBrand"].ToString());
                        coRP.Text = (myReader["prodRP"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry!");
                    entrySearch.Text = "";
                }
                
                con.Close();
            }
        }

        private void coPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            int price = 0;
            if (int.TryParse(coSRP.Text, out price))
            {

            }

            int qty = 1;
            if (int.TryParse(coQty.Text, out qty))
            {

            }

            coSubtotal.Text = Convert.ToString(price * qty);
        }

        private void coSubtotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO datasalesinventory (salesNo, salesItem, salesBrand, salesDate, salesSRP, salesRP, salesQty, salesTotal) VALUES (@sNo, @sItem, @sBrand, @sDate, @sSRP, @sRP, @sQty, @sTotal);";

                cmd.Parameters.AddWithValue("@sNo", entrySearch.Text);
                cmd.Parameters.AddWithValue("@sItem", coItem.Text);
                cmd.Parameters.AddWithValue("@sBrand", coBrand.Text);
                cmd.Parameters.AddWithValue("@sSRP", coSRP.Text);
                cmd.Parameters.AddWithValue("@sRP", coRP.Text);
                cmd.Parameters.AddWithValue("@sQty", coQty.Text);
                cmd.Parameters.AddWithValue("@sTotal", coSubtotal.Text);

                string str = coDOP.Text;
                DateTime dt;
                dt = DateTime.Parse(str);
                cmd.Parameters.AddWithValue("@sDate", dt);

                cmd.Connection = con;
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Data added Sucessfully");
                    entrySearch.Text = "";
                    

                    entrySearch.Focus();
                }

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // GETTING VALUE OF TEXTBOX(Barcode) TO LISTVIEW
        public void populateListView()
        {
            string sql = "SELECT * FROM datainventory WHERE prodNo = '" + coBarCode.Text + "'"; // Sql Statement 
            conn.query(sql); // Command Database
            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    //  0 = Product No, 1 = ProdItem, 2 = ProdBrand, 3 = ProdQty, 4 = ProdSRP, 5 =  prodRP, 6 = ProdDOA, 7 = prodEXPD
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };

                    // Produtct Qty 
                    int qty = Convert.ToInt32(row[3]);

                    // Product SRP
                    int srp = Convert.ToInt32(row[4]);

                    // Add Item/Row to ListView Columns
                    this.listViewinVoice.Items.Add(new Product { prodItem = row[1], prodQty = qty, prodSRP = srp });

                    // Add the price(prodSRP) to the textblock
                    int total = Convert.ToInt32(pay_total.Text); // Convert it first so you can do Arithmetic with the values
                    // if Text is 0 (Default)
                    if (total == 0)
                    {   // Just append the value to the UI (textblock)
                        pay_total.Text = srp.ToString();
                    }
                    else
                    {
                        // If Text is not 0 (It means listview have a existing items)
                        // then add the existing value to the new value
                        int result = total + srp;
                        // Append the result and Update the UI
                        pay_total.Text = result.ToString();
                    }
                }
                conn.Close(); // Close Connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // GETTING VALUE OF LISTVIEW TO TEXTBOX
        private void listViewinVoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selectedItem = (Product)listViewinVoice.SelectedItem; // Your Selected Product Class that Contains ListView Items
                if (listViewinVoice.SelectedIndex >= 0 || listViewinVoice.SelectedItems.Count >= 0)
                {
                    // ADD TO THE LIST VIEW
                    string prodItem = selectedItem.prodItem;
                    int srp = selectedItem.prodSRP;
                    int Qty = selectedItem.prodQty; // Product Qty

                    // Update The UI with the new Value
                    // I USED DATABASE prodSRP AS A PRICE
                    coSRP.Text = srp.ToString();
                    // Some Example data
                    coItem.Text = prodItem;
                    coQty.Text = Qty.ToString(); // Product Qty
                }
            }
            catch (Exception ex)
            {
                return;
            }

        }

        // Remove Product to the listView
        private void removeProduct_Click(object sender, RoutedEventArgs e)
        {
                // Get the  value on  the textBox first to subtract
                int inputPriceToSubtract = Convert.ToInt32(coSRP.Text);
                // Get the value of the total
                int TotalInfo = Convert.ToInt32(pay_total.Text);
                // Subtract the two value
                int subtractTheValue = (TotalInfo - inputPriceToSubtract);
                // Force the result to a absolute value or positive number
                int difference = Math.Abs(subtractTheValue);
                // Then Update the UI
                pay_total.Text = difference.ToString();
                // Remove Items from ListView And UPDATE the UI
                listViewinVoice.Items.RemoveAt(listViewinVoice.SelectedIndex);
        }

        // IN OUR CASE INPUT THE BARCODE ON THE TEXTBOX 
        // CHANGE THE CODE IF REAL SCANNER
        // SCAN BARCODE FROM DATABASE
        private void coBarCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (coBarCode.Text != "")
            {
                populateListView(); // Call the method 
                coBarCode.Text = ""; // After adding a barcode set the textbox to empty again
            }
        }
     
    }
}
