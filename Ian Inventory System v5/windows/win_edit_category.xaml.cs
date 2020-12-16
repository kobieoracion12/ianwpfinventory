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
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_edit_category.xaml
    /// </summary>
    public partial class win_edit_category : Window
    {
        Database conn = new Database();
        string cName = "";
        usc_category usc_categ;

        public win_edit_category(usc_category a)
        {
            InitializeComponent();
            this.usc_categ = a;
            editCateg.Text = returnCategory();
        }

        private void editCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (editCateg.Text == "")
            {
                MessageBox.Show("Field is empty", "Edit Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                editCategory();
                usc_categ.fetchCategoryForOtherForm();
            }
        }


        private String returnCategory()
        {
            string query = "SELECT * FROM category WHERE category_name = '"+ usc_categ.itemCtg.Text + "'";
            conn.query(query);
            try
            {
                conn.Open();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cName = dr["category_name"].ToString();
                    }
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to edit category, Try again later", "Edit Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return cName;
        }

        private void editCategory()
        {
            string query = "UPDATE category SET category_name = @category WHERE category_name = '" + usc_categ.itemCtg.Text + "' ";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@category", editCateg.Text);
                conn.cmd().Prepare();
                conn.execute();
                conn.Close();
                MessageBox.Show("Category name has been changed", "Edit Category Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to edit category, Try again later", "Edit Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                editCategoryBtn_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
