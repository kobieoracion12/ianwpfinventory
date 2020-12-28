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

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for window_change_quantity.xaml
    /// CHANGE QUANTITY PRODUCT IN INVOICE
    /// </summary>
    public partial class window_change_quantity : Window
    {
        Database conn = new Database();
        string transNo;
        string salesItem;
        string prodQty;
        win_pos win_pos;
        public window_change_quantity(win_pos winPOS, string trans_no, string sales_item)
        {
            InitializeComponent();
            win_pos = winPOS;

            transNo = trans_no;
            salesItem = sales_item;
        }

        // IF PRESS ENTER
        private void txtQtyChange_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    conn.Open();
                    string queryQty = "SELECT prodQty FROM datainventory WHERE prodItem = @salesItem";
                    conn.query(queryQty);
                    conn.bind("@salesItem", salesItem);
                    conn.cmd().Prepare();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            prodQty = dr["prodQty"].ToString();
                        }
                    }

                    dr.Close();
                    dr.Dispose();
                    conn.Close();

                    // Check if Database Stock is Less Than users quantity
                    if (int.Parse(prodQty) < int.Parse(txtQtyChange.Text))
                    {
                        MessageBox.Show("Unable to proceed, You only have " + prodQty + " stocks in your database", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                      /* SALES QUANTITY
                     * SET A NEW TOTAL QUANTITY
                     */
                        conn.Open();
                        string query = "UPDATE datasalesinventory SET salesQty = @salesQty  WHERE salesTransNo = @salesTransNo AND salesItem = @salesItem";
                        conn.query(query);
                        conn.bind("@salesQty", txtQtyChange.Text.Trim());
                        conn.bind("@salesTransNo", win_pos.orderNo.Text);
                        conn.bind("@salesItem", salesItem);
                        conn.cmd().Prepare();
                        conn.execute();
                        conn.Close();

                        /* SALES TOTAL
                         * SET A NEW TOTAL PRICE
                         */
                        conn.Open();
                        string query2 = "UPDATE datasalesinventory SET salesTotal = (salesRP * salesQty) WHERE salesTransNo = '" + win_pos.orderNo.Text + "' AND salesItem = '" + salesItem + "' ";
                        conn.query(query2);
                        conn.execute();
                        conn.Close();

                        //MessageBox.Show("Quantity Changed", "Quantiy", MessageBoxButton.OK, MessageBoxImage.Information);
                        win_pos.tbPrdName.Text = ""; //
                        win_pos.holdOrder.IsEnabled = false;
                        this.Close(); // Close

                        win_pos.loadDatas();
                        win_pos.pay_total.Text = win_pos.sumOfSalesTotals(); // Update UI Total
                        conn.Close();
                        win_pos.entrySearch.Focus();
                        win_pos.holdOrder.IsEnabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Prevent User to type Letters
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var txtQtyChange = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = txtQtyChange.Text.Insert(txtQtyChange.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

    }
}
