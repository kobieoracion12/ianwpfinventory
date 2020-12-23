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
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_change_qty : Window
    {
        Database conn = new Database();
        Refund refunds = new Refund();

        string datasalesinventoryQty = "";
        public string data { get; set; }
        public string data2 { get; set; }

        win_refund win_refund;
        public win_change_qty(string data, string data2, win_refund win_refund)
        {
            InitializeComponent();
            //editQuantity.Focus();
            this.data = data;
            this.data2 = data2;

            selectedId.Text = data;
            prodNumber.Text = data2;

            this.win_refund = win_refund;
        }

        // Accepts Only Numbers
        private void editQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var editQuantity = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = editQuantity.Text.Insert(editQuantity.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        // Fetch Available Quantity of the Item from datainventory
        public void fetchInventory()
        {
            
        }

        public int userQty, datasales, salesRefund, datainventory, dataBack;

        // Shortcut
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                confirmButton_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }

        // Update Inventory
        public void dataRefund()
        {
            
        }

        // Confirm Button
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            conn.Close();
            try
            {
                if (currentQty.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty", "Refund", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (int.Parse(currentQty.Text) > int.Parse(datasalesinventoryQty))
                {
                    MessageBox.Show("Your input is too large, "+ datasalesinventoryQty + " is the max", "Refund", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (int.Parse(currentQty.Text) == int.Parse(datasalesinventoryQty))
                {
                    string query = "UPDATE datainventory SET prodQty = (prodQty + @prodQty) WHERE prodNo = @prodNo";
                    conn.query(query);
                    conn.Open();
                    conn.bind("@prodQty", currentQty.Text);
                    conn.bind("@prodNo", data2);
                    conn.cmd().Prepare();
                    var success = conn.execute();
                    if (success > 0)
                    {
                        MessageBox.Show(currentQty.Text + " has been returned to the database", "Refund", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    conn.Close();

                    ////
                    // Delete this stock out item record
                    string removeRecord = "DELETE FROM datasalesinventory WHERE refNo = @refno";
                    conn.query(removeRecord);
                    conn.Open();
                    conn.bind("@refno", data);
                    conn.bind("@prodno", data2);
                    conn.cmd().Prepare();
                    conn.execute();
                    conn.Close();
                    this.Close();
                    win_refund.fetchData();
                    win_refund.itemQuantity.IsEnabled = false;
                    win_refund.itemRefund.IsEnabled = false;
                }
                else
                {
                    // Add data to datainventory
                    string query = "UPDATE datainventory SET prodQty = (prodQty + @prodQty) WHERE prodNo = @prodNo";
                    conn.query(query);
                    conn.Open();
                    conn.bind("@prodQty", currentQty.Text);
                    conn.bind("@prodNo", data2);
                    conn.cmd().Prepare();
                    var success = conn.execute();
                    if (success > 0)
                    {
                        MessageBox.Show(currentQty.Text + " has been returned to the database", "Refund", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    conn.Close();

                    ////
                    string reduceFromStockout = "UPDATE datasalesinventory SET salesQty = (salesQty - @salesQty) WHERE refno = @refno";
                    conn.query(reduceFromStockout);
                    conn.Open();
                    conn.bind("@refno", data);
                    conn.bind("@salesQty", currentQty.Text);
                    conn.cmd().Prepare();
                    conn.execute();
                    conn.Close();
                    ////

                    this.Close();
                    win_refund.fetchData();
                    win_refund.itemQuantity.IsEnabled = false;
                    win_refund.itemRefund.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong returning your item, try again later");
            }
        }

        // Fetch datasales Qty
        private void selectedId_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                conn.Close();
                if (selectedId.Text.Length > 0)
                {
                    conn.Open();
                    string query = "SELECT salesQty FROM datasalesinventory WHERE refNo = @id";
                    conn.query(query); //CMD 
                    conn.bind("@id", selectedId.Text);
                    MySqlDataReader dr = conn.read();
                    if (dr.Read())
                    {
                        datasalesinventoryQty = dr.GetValue(0).ToString();
                        currentQty.Text = dr.GetValue(0).ToString();
                        dr.Close();
                        dr.Dispose(); 
                    }
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Fetch datainventory Qty
        private void currentQty_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (currentQty.Text.Length > 0)
            {
                conn.Close();
                try
                {
                    conn.Open();
                    string query2 = "SELECT prodQty FROM datainventory WHERE prodNo = @no";
                    conn.query(query2); //CMD 
                    conn.bind("@no", data2);
                    MySqlDataReader drr = conn.read();
                    if (drr.Read())
                    {
                        inventoryQty.Text = drr.GetValue(0).ToString();
                        drr.Close();
                        drr.Dispose(); // Dispose
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                    conn.Close();
                }
            }
        }
    }
}
