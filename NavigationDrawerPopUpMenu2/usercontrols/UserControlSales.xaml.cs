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
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2
{
    public partial class UserControlSales : UserControl
    {
        public UserControlSales()
        {
            InitializeComponent();
            catchData();
        }

        private void catchData()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;persistsecurityinfo=True;database=iantestinventory; password='C73DPJxyXICd4Mjq'");
            try
            {
                con.Open();
                string query = "SELECT * FROM datasalesinventory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("datasalesinventory");
                adp.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
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
            window_userLogin userLogin = new window_userLogin();
            userLogin.Show();
        }
    }
}
