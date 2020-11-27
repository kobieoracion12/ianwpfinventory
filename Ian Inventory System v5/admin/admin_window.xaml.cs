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
using NavigationDrawerPopUpMenu2.admin.admin_usercontrols;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.admin
{
    /// <summary>
    /// Interaction logic for admin_window.xaml
    /// </summary>
    public partial class admin_window : Window
    {
        public admin_window()
        {
            InitializeComponent();
            admin_dashboard usd = new admin_dashboard();
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
                    usc = new admin_dashboard();
                    GridMain.Children.Add(usc);
                    break;
                case "manageAcc":
                    usc = new admin_addUsers();
                    GridMain.Children.Add(usc);
                    break;
                case "logoutButton":
                    MessageBox.Show("Logout Success!", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
                    window_userLogin userLogin = new window_userLogin();
                    userLogin.Show();
                    this.Close();
                    break;
            }
        }
    }
}
