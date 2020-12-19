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
using NavigationDrawerPopUpMenu2.classes;
using MySql.Data.MySqlClient;
using System.Data;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class win_settings : Window
    {
        Database conn = new Database();
        Checkout checkout = new Checkout();
        Settings setting = new Settings();
        win_pos win_pos;
        Authentication auth; 
        public win_settings(win_pos winPOS)
        {
            InitializeComponent();
            win_pos = winPOS;

            st_cashier_name.Text = win_pos.cashierName.Text;
            st_acc_no.Text = win_pos.accNo.Text;

            fetchCashier();
        }

        // Fetch User
        public void fetchCashier()
        {
            string sql = "SELECT usersName from usersinventory WHERE acc_no = '" + st_acc_no.Text + "'";
            conn.query(sql);

            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0) };
                    settingUser.Text = row[0];
                }

                reader.Close();
                reader.Dispose();
                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Return Button
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Save Button
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (settingOldPass.Password == "" || settingNewPass.Password == "" || settingConfirmPass.Password == "")
            {
                MessageBox.Show("One or more fields are empty", "Change Password", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (settingConfirmPass.Password != settingNewPass.Password)
            {
                MessageBox.Show("Password does not match", "Change Password", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                auth = new Authentication(st_cashier_name.Text, settingOldPass.Password);
                try
                {
                    // Check User Pass if Correct
                    if (auth.checkUserPasswordByAccNo(st_acc_no.Text))
                    {
                            var hashedPwd = BCrypt.Net.BCrypt.HashPassword(settingNewPass.Password);
                            string sql = "UPDATE usersinventory SET usersName = @name, usersPass = @pass WHERE acc_no = @no";
                            conn.query(sql);

                            conn.Open();
                            conn.bind("@name", settingUser.Text);
                            conn.bind("@pass", hashedPwd);
                            conn.bind("@no", st_acc_no.Text);

                            conn.cmd().Prepare();
                            var succes = conn.execute();
                            if (succes > 0)
                            {
                                MessageBox.Show("Your password has been changed", "Change Password", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your old password is wrong", "Change Password", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong changing your password", "Change Password", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void save()
        {
            
        }

        // Password Validation
        public void passwordValidation()
        {

        }
    }
}
