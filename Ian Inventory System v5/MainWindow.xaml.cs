using NavigationDrawerPopUpMenu2.classes;
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
        string accNo = "";
        DateTime timeIn;
        public MainWindow(string acc_no, DateTime timeIn)
        {
            InitializeComponent();
            accNo = acc_no;
            this.timeIn = timeIn;
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
                case "dashboardHome":
                    usc = new usc_dashboard();
                    GridMain.Children.Add(usc);
                    break;
                case "manageUsers":
                    usc = new usc_accounts();
                    GridMain.Children.Add(usc);
                    break;
                case "salesInventory":
                    usc = new usc_sales_inventory();
                    GridMain.Children.Add(usc);
                    break;
                case "inventoryStocks":
                    usc = new usc_inventory();
                    GridMain.Children.Add(usc);
                    break;
                case "posSettings":
                    usc = new usc_pos_settings();
                    GridMain.Children.Add(usc);
                    break;
                case "categoryButton":
                    usc = new usc_category();
                    GridMain.Children.Add(usc);
                    break;
                case "stockOutButton":
                    usc = new usc_stockout();
                    GridMain.Children.Add(usc);
                    break;
                case "stockReturnButton":
                    usc = new usc_stockreturn();
                    GridMain.Children.Add(usc);
                    break;
                case "settingsButton":
                    usc = new usc_settings();
                    GridMain.Children.Add(usc);
                    break;
                case "logoutButton":
                    var ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (ans == MessageBoxResult.Yes)
                    {
                        MessageBox.Show("Logout Success!", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
                        window_userLogin userLogin = new window_userLogin(); // Call UserLogin Window
                        /* Authentication auth = new Authentication("", ""); // Call Auth Class
                         auth.addTimeInOut(timeIn, accNo); */
                        userLogin.Show(); // Show Login After Logout
                        this.Close(); // Close this window
                    }
                    break;
            }
        }
    }
}
