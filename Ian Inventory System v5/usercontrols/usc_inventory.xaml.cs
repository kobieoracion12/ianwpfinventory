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
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.windows;
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_inventory : UserControl
    {
        Database conn = new Database();
        usc_parent_request upr = new usc_parent_request();
        public static int prdID;
        public WindowState WindowState { get; private set; }

        public usc_inventory()
        {
            InitializeComponent();
            usc_parent_overview upo = new usc_parent_overview();
            mainSubColumn.Children.Add(upo);
        }

        // Add Item Button
        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            window_addItem addItem = new window_addItem();
            addItem.Show();
        }

        // Restock Item Button
        private void restockItem_Click(object sender, RoutedEventArgs e)
        {
            window_restockItem restockItem = new window_restockItem();
            restockItem.ShowDialog();
        }

        // Buttons
        private void ListViewMenu_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            mainSubColumn.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "stStocks":
                    usc = new usc_parent_overview();
                    mainSubColumn.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new usc_sales();
                    mainSubColumn.Children.Add(usc);
                    break;
                case "stItemReq":
                    usc = new usc_parent_request();
                    mainSubColumn.Children.Add(usc);
                    break;
                case "stRestock":
                    usc = new usc_parent_restock();
                    mainSubColumn.Children.Add(usc);
                    break;
            }
        }
    }
}
