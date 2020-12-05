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

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_settings.xaml
    /// </summary>
    public partial class win_settings : Window
    {
        Checkout checkout = new Checkout();
        win_pos win_pos;

        public win_settings(win_pos winPOS)
        {
            InitializeComponent();
            win_pos = winPOS;

            st_cashier_name.Text = win_pos.cashierName.Text;
            st_acc_no.Text = win_pos.accNo.Text;
        }


        // Return Button
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
