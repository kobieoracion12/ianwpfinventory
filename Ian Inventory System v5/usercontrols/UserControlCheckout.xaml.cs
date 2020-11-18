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
        }

        public UserControlCheckout(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public string Value { get; set; } // Create a variable to store the value


        // When Checkout loads
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            window_cashButton.myCash = cashAmount.Text;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }
        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            this.cashAmount.Text = msg;
        }

        private void cashAmount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
