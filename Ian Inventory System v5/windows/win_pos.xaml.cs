using NavigationDrawerPopUpMenu2.classes;
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

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_pos.xaml
    /// </summary>
    public partial class win_pos : Window
    {
        window_userLogin lgn;
        Database conn = new Database();
        Authentication auth;
        public win_pos(window_userLogin frmLogin)
        {
            InitializeComponent();
            auth = new Authentication("", "");
            lgn = frmLogin;
        }

        // Window Loads
        private void WindowPOS_Loaded(object sender, RoutedEventArgs e)
        {
            // Display Time In
            timeIn.Text = DateTime.Now.ToLongTimeString();
            // Display Account Number
            accNo.Text = auth.getAccNo(lgn.txtUsername.Text);
            // Display Cashier Name
            cashierName.Text = auth.getFullName(accNo.Text);
        }

        // Logout Button
        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            auth.addTimeInOut(timeIn.Text, accNo.Text); // Bug 
            window_userLogin posLogin = new window_userLogin();
            posLogin.Show();
            this.Close();
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            //checkout.payMethod = "Cash";
            window_cashButton cf = new window_cashButton();
            //cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            //cf.ShowDialog();
        }

    }
}
