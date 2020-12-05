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
        public window_change_quantity(win_pos winPOS, string trans_no, string sales_item, string prod_qty)
        {
            InitializeComponent();
            win_pos = winPOS;

            transNo = trans_no;
            salesItem = sales_item;
            prodQty = prod_qty;
        }

        // IF PRESS ENTER
        private void txtQtyChange_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    /* SALES QUANTITY
                     * SET A NEW TOTAL QUANTITY
                     */
                    conn.Open();
                    string query = "UPDATE datasalesinventory SET salesQty = @salesQty  WHERE salesTransNo = @salesTransNo AND salesItem = @salesItem";
                    conn.query(query);
                    conn.bind("@salesQty", txtQtyChange.Text);
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

                    MessageBox.Show("Quantity Changed", "Quantiy", MessageBoxButton.OK, MessageBoxImage.Information);
                    win_pos.tbPrdName.Text = ""; //
                    win_pos.holdOrder.IsEnabled = false;
                    this.Close(); // Close
                    win_pos.loadData();
                    win_pos.pay_total.Text = win_pos.sumOfSalesTotal();
                    win_pos.entrySearch.Focus();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        
    }
}
