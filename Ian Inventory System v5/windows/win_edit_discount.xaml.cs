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
using MySql.Data.MySqlClient;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_edit_discount.xaml
    /// </summary>
    public partial class win_edit_discount : Window
    {
        Database conn = new Database();
        usc_pos_settings usc_disc;
        public win_edit_discount(usc_pos_settings usc_disc)
        {
            InitializeComponent();
            this.usc_disc = usc_disc;
            getDiscount();
        }

        // Edit Discount
        private void editDiscBtn_Click(object sender, RoutedEventArgs e)
        {
            if (editDiscName.Text == "" || editDiscPercent.Text == "")
            {
                MessageBox.Show("Fields cannot be empty", "Edit Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else
            {
                editDiscount();
                usc_disc.loadDiscount();
                this.Close();
            }
        }

        private void editDiscount()
        {
            try
            {
                string query = "UPDATE discount SET discount_name = @discount_name, discount_percent = @discount_percent WHERE discount_name = @discName";
                conn.query(query);
                conn.Open();
                conn.bind("@discount_name", editDiscName.Text);
                conn.bind("@discount_percent", editDiscPercent.Text);
                conn.bind("@discName", usc_disc.tbDiscountName.Text);
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Discount has been change", "Edit Discount", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Something went wrong, Please try again later\n" + ex.Message, "Edit Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void getDiscount()
        {
            try
            {
                conn.Open();
                string queryQty = "SELECT * FROM discount WHERE discount_name = @discount_name";
                conn.query(queryQty);
                conn.bind("@discount_name", usc_disc.tbDiscountName.Text);
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        editDiscName.Text = dr["discount_name"].ToString();
                        editDiscPercent.Text = dr["discount_percent"].ToString();
                    }
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Something went wrong, Please try again later\n" + ex.Message, "Edit Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        // Prevent user to type letters or char
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var editDiscPercent = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = editDiscPercent.Text.Insert(editDiscPercent.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        // Shortcut keys
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                editDiscBtn_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
