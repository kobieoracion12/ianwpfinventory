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

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_add_brand.xaml
    /// </summary>
    public partial class win_add_brand : Window
    {
        Database conn = new Database();
        UserControlBrand usc_brand;
        public win_add_brand(UserControlBrand usc_brand)
        {
            InitializeComponent();
            this.usc_brand = usc_brand;
        }

        // Add Category
        private void adBrandBtn_Click(object sender, RoutedEventArgs e)
        {
            if (addBrand.Text == "")
            {
                MessageBox.Show("Field is empty!", "Add Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                addBrands();
                addBrand.Text = "";
                usc_brand.catchData();
            }

        }

        private void addBrands()
        {
            string query = "INSERT INTO brand(brand_name) VALUES(@brand)";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@brand", addBrand.Text);
                conn.execute();
                conn.Close();
                MessageBox.Show("Brand added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to add brand, Try again later", "Add Brand Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // KeyDown
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                adBrandBtn_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
