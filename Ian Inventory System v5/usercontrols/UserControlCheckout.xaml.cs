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
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlCheckout : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=iantestinventory;");
        public UserControlCheckout()
        {
            InitializeComponent();
            startUp();
        }

        public void startUp()
        {
            cashAmount.Text = window_cashButton.cashInput;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;

                DataTable dt = new DataTable();
                con.Open();
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM datainventory WHERE prodNo= '" + search + "'", con);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    coItem.Text = (myReader["prodItem"].ToString());
                    coPrice.Text = (myReader["prodPrice"].ToString());
                }
                con.Close();
                entrySearch.Focus();

                ListViewItem lvwItem = listViewinVoice.Items.Add("my first text");
                lvwItem.SubItems.Add("my second text");
                lvwItem.SubItems.Add("my third text");
            }
            */
        }


        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            window_cashButton wsb = new window_cashButton();
            wsb.Show();
        }
    }
}
