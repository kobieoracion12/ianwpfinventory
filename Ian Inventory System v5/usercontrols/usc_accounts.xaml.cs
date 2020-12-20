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
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;
using Microsoft.Reporting.WinForms;
using NavigationDrawerPopUpMenu2.reports;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_accounts : UserControl
    {
        public usc_accounts()
        {
            InitializeComponent();
            usc_user_overview upo = new usc_user_overview();
            mainSubColumn.Children.Add(upo);
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            mainSubColumn.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "accManage":
                    usc = new usc_user_overview();
                    mainSubColumn.Children.Add(usc);
                    break;
                case "accAdd":
                    usc = new usc_parent_add_item();
                    mainSubColumn.Children.Add(usc);
                    break;

            }
        }
    }
}
