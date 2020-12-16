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
    /// Interaction logic for win_add_category.xaml
    /// </summary>
    public partial class win_add_category : Window
    {
        Database conn = new Database();
        usc_category usc_categ;

        public win_add_category(usc_category usc_categ)
        {
            InitializeComponent();
            this.usc_categ = usc_categ;
        }

        // Add Category
        private void addCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            if(addCateg.Text == "")
            {
                MessageBox.Show("Field is empty!", "Add Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                addCategories();
                addCateg.Text = "";
                usc_categ.fetchCategory();
            }
            
        }

        private void addCategories()
        {
            string query = "INSERT INTO category(category_name) VALUES(@category)";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@category", addCateg.Text);
                conn.execute();
                conn.Close();
                MessageBox.Show("Category added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to add category, Try again later", "Add Category Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // KeyDown
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                addCategoryBtn_Click(sender, e);
            else if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
