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
        Database con = new Database();

        public UserControlCheckout()
        {
            InitializeComponent();
            startUp();
        }

        public void startUp()
        {
            cashAmount.Text = window_cashButton.cashInput;
        }

        public void Refresh()
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }


        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            window_cashButton wsb = new window_cashButton();
            wsb.Show();
        }
    }
}
