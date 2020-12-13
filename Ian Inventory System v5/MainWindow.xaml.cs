using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.windows;
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

namespace NavigationDrawerPopUpMenu2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            usc_dashboard usd = new usc_dashboard();
            GridMain.Children.Add(usd);
        }
        
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new usc_dashboard();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new usc_sales();
                    GridMain.Children.Add(usc);
                    break;
                case "inventoryStocks":
                    usc = new usc_inventory();
                    GridMain.Children.Add(usc);
                    break;
                case "checkOut":
                    usc = new UserControlCheckout();
                    GridMain.Children.Add(usc);
                    break;
                case "logoutButton":
                    MessageBox.Show("Logout Success!", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
                    window_userLogin userLogin = new window_userLogin();
                    userLogin.Show();
                    this.Close();
                    break;
                case "categoryButton":
                    usc = new UserControlInventory();
                    GridMain.Children.Add(usc);
                    break;
                case "stockOutButton":
                    usc = new UserControlCheckout();
                    GridMain.Children.Add(usc);
                    break;
                case "stockReturnButton":
                    usc = new usc_stockreturn();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    usc = new UserControlDashboard();
                    GridMain.Children.Add(usc);
                    break;
            }

        }
    }
}
