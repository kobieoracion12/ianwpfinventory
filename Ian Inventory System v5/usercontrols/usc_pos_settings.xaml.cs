using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    /// <summary>
    /// Interaction logic for usc_pos_settings.xaml
    /// </summary>
    public partial class usc_pos_settings : UserControl
    {
        Database conn = new Database();
        public usc_pos_settings()
        {
            InitializeComponent();
            loadDiscount();
        }

        // Add Discount
        private void addDiscount_Click(object sender, RoutedEventArgs e)
        {
            if (discountName.Text == "" || discountValue.Text == "")
            {
                MessageBox.Show("The fields cannot be empty", "Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (discountValue.Text.Contains("%"))
            {
                MessageBox.Show("Unable to proceed because of percent symbol", "Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                addDiscount(); // Add Discount
                loadDiscount();
            }
        }

        // Add Discount method
        private void addDiscount()
        {
            try
            {
                bool doesExist = false;
                string query = "SELECT * FROM discount WHERE discount_name = @discount_name";
                conn.query(query);
                conn.Open();
                conn.bind("@discount_name", discountName.Text);
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    doesExist = true;
                }
                else
                {
                    doesExist = false;
                }

                dr.Close();
                dr.Dispose();
                conn.Close();

                if (doesExist)
                {
                    MessageBox.Show("Discount name is already exist", "Add Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    string addDiscountQuery = "INSERT INTO discount(discount_name, discount_percent) VALUES(@discount_name, @discount_percent)";
                    conn.query(addDiscountQuery);
                    conn.Open();
                    conn.bind("@discount_name", discountName.Text);
                    conn.bind("@discount_percent", discountValue.Text);
                    conn.cmd().Prepare();
                    var success = conn.execute();
                    if (success > 0)
                    {
                        MessageBox.Show("A new discount has been added", "Add Discount", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    discountName.Text = "";
                    discountValue.Text = "";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Something went wrong, Please try again later\n" + ex.Message, "Add Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Load Discount
        public void loadDiscount()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM discount ORDER BY discount_name ASC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("discount");
                // Fill the datatable
                adapter.Fill(dt);
                listViewDiscount.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Prevent User to type letters/Char
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var discountValue = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = discountValue.Text.Insert(discountValue.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }

        // pass data listview to textbox
        private void listViewDiscount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // Get the product id
                string discountName = listViewDiscount.SelectedItems[1].ToString();
                // Append ID and Product name
                tbDiscountName.Text = discountName;

            }
            catch (Exception ex)
            {
                return;
            }
        }

        // Edit Discount
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbDiscountName.Text == "")
            {
                MessageBox.Show("No selected discount", "Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else {
                win_edit_discount editDiscWin = new win_edit_discount(this);
                editDiscWin.ShowDialog();
            }
            
        }

        // Remove Discount
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbDiscountName.Text == "")
            {
                MessageBox.Show("No selected discount", "Remove Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                removeDiscount();
                loadDiscount();
            }
        }

        // Remove Discount Method
        private void removeDiscount()
        {
            string query = "DELETE FROM discount WHERE discount_name = @discount_name";
            try
            {
                conn.query(query);
                conn.Open();
                conn.bind("@discount_name", tbDiscountName.Text);
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Discount has been successfully removed", "Remove Discount", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Removing discount failed, Please try again later", "Remove Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void Clear()
        {
            discountName.Clear();
            discountValue.Clear();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
