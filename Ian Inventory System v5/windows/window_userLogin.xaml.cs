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
using NavigationDrawerPopUpMenu2.admin;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class window_userLogin : Window
    {
        public DateTime userTimeIn = DateTime.Now;
        public string userTimeOut = "";
        public string acc_no = "";
        MainWindow logoutControl;

        public window_userLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        Database conn = new Database();
        Login login = new Login();

        public void Login()
        {
            string username = txtUsername.Text.Trim();
            string pwd = txtPassword.Password.Trim();
            // Call Auth Class
            Authentication auth = new Authentication(username, pwd);

            acc_no = auth.getAccNo(username);
            if (auth.isEmpty())
            {
                MessageBox.Show("Fields cannot be empty", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // Check if username in database
                if (auth.checkUsername())
                {
                    // If Password is Correct
                    if (auth.checkUserPassword())
                    {
                        try
                        {
                            string userPrev = auth.getUserPrevilages(); // Users Previleges
                            if (userPrev.Equals("Admin"))
                            { // Go to Admin Dashboard
                                admin_window adminDashboard = new admin_window();
                                adminDashboard.Show(); // Show Dashboard
                                this.Close(); // Close Login
                            }
                            else if (userPrev.Equals("Users"))
                            { // Go to Users Dashboard
                                MainWindow usersDashbord = new MainWindow(acc_no, userTimeIn);
                                usersDashbord.Show(); // Show Dashboard
                                this.Close(); // Close Login
                            }
                            else if (userPrev.Equals("Cashier"))
                            { // Go to Users Dashboard

                                win_pos checkoutCashier = new win_pos(this);
                                checkoutCashier.Show(); // Show Dashboard
                                this.Close(); // Close Login
                            }
                            else
                            {   // IF Something Went Wrong // Error
                                MessageBox.Show("Something went wrong, Please try again later", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                    }
                    else
                    {
                        // Wrong Pass
                        MessageBox.Show("Invalid Username or Password", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {   // No user 
                    MessageBox.Show("Invalid Username or Password", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        // Login Button
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Login();
            userTimeIn = DateTime.Now; // Set a DateTime
        }

        

        // Exit Program
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0); // Exit program
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Login();
            }
        }
    }
}
