using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;
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

        private void addDiscount()
        {
            try
            {
                string query = "INSERT INTO discount(discount_name, discount_percent) VALUES(@discount_name, @discount_percent)";
                conn.query(query);
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
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Something went wrong, Please try again later\n" + ex.Message, "Add Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

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
    }
}
