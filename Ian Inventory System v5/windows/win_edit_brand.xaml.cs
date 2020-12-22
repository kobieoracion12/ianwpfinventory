using MySql.Data.MySqlClient;
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
    /// Interaction logic for win_edit_brand.xaml
    /// </summary>
    public partial class win_edit_brand : Window
    {
        Database conn = new Database();
        UserControlBrand usc_brand;
        string cName = "";
        public win_edit_brand(UserControlBrand usc_brand)
        {
            InitializeComponent();
            this.usc_brand = usc_brand;
            editBrand.Text = returnBrand();
        }

        private void editBrandBtn_Click(object sender, RoutedEventArgs e)
        {
            if (editBrand.Text == "")
            {
                MessageBox.Show("Field is empty", "Edit Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                editCategory();
                usc_brand.catchData();
            }
        }


        private String returnBrand()
        {
            string query = "SELECT * FROM brand WHERE bId = '" + usc_brand.tbPrdId.Text + "'";
            conn.query(query);
            try
            {
                conn.Open();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cName = dr["brand_name"].ToString();
                    }
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to edit brand, Try again later", "Edit Brand Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return cName;
        }

        private void editCategory()
        {
            string query = "UPDATE brand SET brand_name = @brand WHERE bId = '" + usc_brand.tbPrdId.Text + "' ";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@brand", editBrand.Text);
                conn.cmd().Prepare();
                conn.execute();
                conn.Close();
                MessageBox.Show("Brand name has been changed", "Edit Brand Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Unable to edit brand, Try again later", "Edit Brand Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                editBrandBtn_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
