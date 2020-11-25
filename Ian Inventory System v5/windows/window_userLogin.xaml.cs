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
            try
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM userinventory WHERE userName=@username AND userPass=@password";
                conn.query(query);

                cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Password);
                cmd.Connection = con;

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Login Success!");
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

    }
}
