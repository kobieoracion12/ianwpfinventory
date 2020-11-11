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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.windows;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2
{
    public partial class UserControlInventory : UserControl
    {
        public WindowState WindowState { get; private set; }

        public UserControlInventory()
        {
            InitializeComponent();
            catchData();

        }
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;persistsecurityinfo=True;database=iantestinventory; password='C73DPJxyXICd4Mjq'");

        public void catchData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM datainventory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datainventory");
                adp.Fill(dt);
                listViewInventory.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window_addItem addItem = new window_addItem();
            addItem.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            catchData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void listViewInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
