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
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.admin
{
    /// <summary>
    /// Interaction logic for admin_create.xaml
    /// </summary>
    public partial class admin_create : UserControl
    {
        Database conn = new Database();
        public string username = "";
        public string password = "";
        public string privilege = "";

        public admin_create()
        {
            InitializeComponent();
        }

        private void piNextButton_Click(object sender, RoutedEventArgs e)
        {
            username = userName.Text;
            password = passWord.Password;
            privilege = accPrivilege.Text;

            string query = "INSERT INTO usersinventory (usersName, usersPass, usersPrevilages) VALUES (@username, @password, @privilege)";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@username", username);
                conn.bind("@password", password);
                conn.bind("@privilege", privilege);
                conn.cmd().Prepare();
                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("User Added~!");
                    Environment.Exit(0);
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
