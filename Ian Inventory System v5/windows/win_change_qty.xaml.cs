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

        public string data { get; set; }
        public string data2 { get; set; }

        public win_change_qty(string data, string data2)
        {
            InitializeComponent();
            editQuantity.Focus();

            this.data = data;
            this.data2 = data2;

            selectedId.Text = data;
            prodNumber.Text = data2;
        }

        // Accepts Only Numbers
        private void editQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var entrySearch = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = entrySearch.Text.Insert(entrySearch.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        // Fetch Available Quantity of the Item from datainventory
        public void fetchInventory()
        {
            
            
        }

        public int userQty, datasales, salesRefund, datainventory, dataBack;

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
                userQty = int.Parse(editQuantity.Text);
                datasales = int.Parse(currentQty.Text);

                salesRefund = datasales - userQty;

                string salesquery = "UPDATE datasalesinventory SET salesQty = @qty WHERE refNo = @no";
                conn.query(salesquery);
                try
                {
                    conn.Open();
                    conn.bind("@qty", salesRefund);
                    conn.bind("@no", selectedId);
                    var check = conn.execute();
                    if (check == 1)
                    {
                        conn.Close();
                        try
                        {
                            datainventory = int.Parse(inventoryQty.Text);

                            dataBack = datainventory - salesRefund;

                            string dataquery = "UPDATE datainventory SET prodQty = @qty WHERE prodNo = @no";
                            conn.query(dataquery);
                            try
                            {
                                conn.Open();
                                conn.bind("@qty", dataBack);
                                conn.bind("@no", prodNumber);
                                var checkk = conn.execute();
                                if (checkk == 1)
                                {
                                    MessageBox.Show("Data Refunded");
                                    conn.Close();
                                    Close();
                                }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                                conn.Close();
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                            conn.Close();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
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
