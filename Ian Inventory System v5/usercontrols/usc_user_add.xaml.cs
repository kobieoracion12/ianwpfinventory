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
using MySql.Data.MySqlClient;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_user_add : UserControl
    {
        Database conn = new Database();
        clientInfo clientInfo = new clientInfo();

        Authentication auth;
        public usc_user_add()
        {
            InitializeComponent();
            accNumberGen();
        }

        // Account Number Generator
        public string accNumberGen()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
                string query = "SELECT COUNT(1) FROM usersinventory WHERE acc_no = @accNo";
                conn.query(query);
                try
                {
                    conn.Open();
                    conn.bind("@accNo", r);
                    conn.cmd().Prepare();
                    var check = conn.execute();
                    if (check == 1)
                    {
                        accNumberGen();
                    }
                    else
                    {
                        accNumber.Text = Convert.ToString(r);
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            return r;
        }

        // Clear Textbox
        public void ClearTextbox()
        {
            accNumber.Clear();
            firstName.Clear();
            lastName.Clear();
            userName.Clear();
            passWord.Clear();
            accBussName.Clear();
            accBranch.Clear();
            accBussType.Clear();
            accTown.Clear();
            accProvince.Clear();
            accCountry.Clear();
            accZipcode.Clear();
        }

        // Save Button 
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string username = userName.Text;
            string password = passWord.Password;

            auth = new Authentication(username, password);

            if (accNumber.Text == "" || lastName.Text == "" || firstName.Text == "" || userName.Text == "" || passWord.Password == "" || accPrivilege.Text == "" || accBussName.Text == "" || accBussType.Text == "" || accTown.Text == "" || accProvince.Text == "" || accCountry.Text == "" || accZipcode.Text == "" || accCreated.Text == "")
            {
                MessageBox.Show("Please Complete the Form", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (accBranch.Text == "")
                {
                    accBranch.Text = "N/A";
                }
                  
                auth.addUser(accPrivilege.Text, accNumber.Text);

                clientInfo.acc_number = Convert.ToInt64(accNumber.Text);
                clientInfo.first_name = firstName.Text;
                clientInfo.last_name = lastName.Text;
                clientInfo.buss_name = accBussName.Text;
                clientInfo.buss_branch = accBranch.Text;
                clientInfo.buss_type = accBussType.Text;
                clientInfo.buss_town = accTown.Text;
                clientInfo.buss_province = accProvince.Text;
                clientInfo.buss_country = accCountry.Text;
                clientInfo.buss_zipcode = Convert.ToInt32(accZipcode.Text);

                clientInfo.registerClient();
                clientInfo.Clear();
                ClearTextbox();

            }
        }
    }
}
