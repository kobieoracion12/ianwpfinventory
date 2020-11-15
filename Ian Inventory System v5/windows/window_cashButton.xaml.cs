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
    public partial class window_cashButton : Window
    {
        public window_cashButton()
        {
            InitializeComponent();
        }

        public static string cashInput = "₱ 0.00";

        private void entrySearch_KeyDown(object sender, KeyEventArgs e)
        {
            UserControlCheckout uscc = new UserControlCheckout();
            cashInput = "₱ " + entrySearch.Text;
            if (e.Key == Key.Return)
            {
                this.Close();
                uscc.InitializeComponent();
            }
        }
    }
}
