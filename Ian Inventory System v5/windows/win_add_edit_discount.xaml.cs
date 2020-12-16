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
    /// Interaction logic for win_add_edit_discount.xaml
    /// </summary>
    public partial class win_add_edit_discount : Window
    {
        Database conn = new Database();

        public win_add_edit_discount()
        {
            InitializeComponent();
        }

        private void addDiscount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO discount(discount_name, discount_percent) VALUES(@discount_name, @discount_percent)";
                conn.bind("@discount_name", discName.Text);
                conn.bind("@discount_percent", percent.Text);
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("A new discount has been added", "Add Discount", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Something went wrong in your selection", "Add Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
