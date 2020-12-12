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
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    // Data Send Handler
    public delegate void DataSendHandler(String msg);
    public partial class window_cashButton : Window
    {
        public event DataSendHandler DataSent;
        public static string myCash;
        Checkout checkout = new Checkout();

        string paytotal = "";
        public window_cashButton()
        {
            InitializeComponent();
            cashAmount.Focus();
        }

        public String total(string payTotal)
        {
            paytotal = payTotal;
            return paytotal;
        }

        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                
                if (int.Parse(cashAmount.Text) < int.Parse(total(paytotal)))
                {
                    MessageBox.Show("Insufficient Payment", "Cash", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    // Send the cash back to the parent usercontrol/form
                    this.DataSent(cashAmount.Text);
                    this.Close(); // Then Close the Window
                }
            }
        }

    }
}
