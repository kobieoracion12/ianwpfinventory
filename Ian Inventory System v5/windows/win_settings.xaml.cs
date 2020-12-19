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
            setting.posUser = settingUser.Text;
            setting.posNewPass = settingCurrentPass.Password;
            setting.posCurPass = settingConfirmPass.Password;

            string sql = setting.savePosInfo;
            conn.query(sql);
            conn.Close();
            try
            {
                conn.Open();
                conn.bind("@no", setting.strId);
                conn.bind("@name", setting.posUser);
                conn.bind("@pass", setting.posNewPass);

                conn.cmd().Prepare();
                conn.execute();

                MessageBox.Show("Successfully Updated");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Password Validation
        public void passwordValidation()
        {

        }
    }
}
