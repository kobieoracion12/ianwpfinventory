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
using NavigationDrawerPopUpMenu2.admin.admin_usercontrols;
using NavigationDrawerPopUpMenu2.admin;
using NavigationDrawerPopUpMenu2.classes;
using MySql.Data.MySqlClient;

namespace NavigationDrawerPopUpMenu2.admin
{
    public partial class admin_personalInfo : UserControl
    {
        Database conn = new Database();
        clientInfo clientInfo = new clientInfo();
        public admin_personalInfo()
        {
            InitializeComponent();
            accNumberGen();
        }

        public string accNumberGen()
        {
            Random random = new Random();
            string r = ""; 
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
                string query = "SELECT COUNT(1) FROM usersinventory WHERE usersId = @accNo";
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

        private void piNextButton_Click(object sender, RoutedEventArgs e)
        {
            if (accNumber.Text == "" || lastName.Text == "" || firstName.Text == "" || userName.Text == "" || passWord.Password == "" || accPrivilege.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                clientInfo.acc_number = Convert.ToInt64(accNumber.Text);
                clientInfo.first_name = firstName.Text;
                clientInfo.last_name = lastName.Text;

                tabControlMain.SelectedIndex++;
            }
        }

        private void bussButton_Click(object sender, RoutedEventArgs e)
        {
            if (accBussName.Text == "" || accBranch.Text == "" || accBussType.Text == "" || accTown.Text == "" || accProvince.Text == "" || accCountry.Text == "" || accZipcode.Text == "" || accCreated.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                clientInfo.buss_name = accBussName.Text;
                clientInfo.buss_branch = accBranch.Text;
                clientInfo.buss_type = accBussType.Text;
                clientInfo.buss_town = accTown.Text;
                clientInfo.buss_province = accProvince.Text;
                clientInfo.buss_country = accCountry.Text;
                clientInfo.buss_zipcode = Convert.ToInt32(accZipcode.Text);

                clientInfo.registerClient();
                MessageBox.Show("Data Added!");
                clientInfo.Clear();
                ClearTextbox();

                tabControlMain.SelectedIndex--;
            }
        }
    }
}
