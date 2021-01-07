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

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_stock : UserControl
    {
        public usc_stock()
        {
            InitializeComponent();
            usc_stock_history upo = new usc_stock_history();
            mainSubColumn.Children.Add(upo);
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            mainSubColumn.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "stockStockin":
                    usc = new usc_user_in();
                    mainSubColumn.Children.Add(usc);
                    break;

                case "stockStockOut":
                    usc = new usc_user_out();
                    mainSubColumn.Children.Add(usc);
                    break;

                case "stockinInventory":
                    usc = new usc_stock_history();
                    mainSubColumn.Children.Add(usc);
                    break;

                case "stockoutInventory":
                    usc = new usc_stockout_history();
                    mainSubColumn.Children.Add(usc);
                    break;
            }
        }
    }
}
