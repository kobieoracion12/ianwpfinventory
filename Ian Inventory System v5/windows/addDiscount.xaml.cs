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
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for addDiscount.xaml
    /// </summary>
    public partial class addDiscount : Window
    {
        Database conn = new Database();
        string salesItem;
        string prodTotal;
        win_pos win_pos;
        public addDiscount(string sales_item, win_pos pos)
        {
            InitializeComponent();
            salesItem = sales_item;
            win_pos = pos;
        }

        // Add Discount
        private void addDiscBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(addDisc.Text) <= 100)
                {
                    conn.Open();
                    string queryQty = "SELECT salesTotal FROM datasalesinventory WHERE salesStatus = 'Pending'";
                    conn.query(queryQty);
                    conn.bind("@salesItem", salesItem);
                    conn.cmd().Prepare();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            prodTotal = dr["salesTotal"].ToString();
                        }
                    }

                    dr.Close();
                    dr.Dispose();
                    conn.Close();

                    // Do The Calculation
                    double discount = double.Parse(addDisc.Text) / 100;
                    int originalPrice = int.Parse(prodTotal);

                    // Multiply the original price by the decimal(discount)
                    double multiplyPriceByDecimalDiscount = (originalPrice * discount);

                    // Subtract the discount from the original price:
                    double subtractDiscountToOrigPrice = (originalPrice - multiplyPriceByDecimalDiscount);
                    // Answer - subtractDiscountToOrigPrice
                    int discountedPrice = Convert.ToInt32(subtractDiscountToOrigPrice);

                    conn.Open();
                    string addDiscountToPrice = "UPDATE datasalesinventory SET salesTotal = @total WHERE salesItem = @item AND salesStatus = 'Pending'";
                    conn.query(addDiscountToPrice);
                    conn.bind("@total", subtractDiscountToOrigPrice);
                    conn.bind("@item", salesItem);
                    conn.cmd().Prepare();
                    conn.execute(); // Execute
                    conn.Close();
                    MessageBox.Show("Discount Added", "Discount", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close(); // Close
                    win_pos.pay_total.Text = win_pos.sumOfSalesTotal(); // Update UI
                }
                else
                {
                    MessageBox.Show("Discount Percent is only up to 100", "Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + " , Please try again later", "Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        // Exit
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {   // Close using escape
            if (e.Key == Key.Escape)
                this.Close();
            else if (e.Key == Key.Return)
                addDiscBtn_Click(sender, e);
        }

        // Prevent User to type LETTERS
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var addDisc = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = addDisc.Text.Insert(addDisc.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        
    }
}
