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
using System.Data;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for window_userLogin.xaml
    /// </summary>
    public partial class window_userLogin : Window
    {
        public window_userLogin()
        {
            InitializeComponent();
        }

        Database conn = new Database();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT COUNT(1) FROM userinventory WHERE userName=@username AND userPass=@password";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@username", tbUsername.Text);
                conn.bind("@password", tbPassword.Password);
                conn.cmd().Prepare();
                

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

    }
}
