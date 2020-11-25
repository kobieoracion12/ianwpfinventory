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
using NavigationDrawerPopUpMenu2.admin.admin_usercontrols;
using NavigationDrawerPopUpMenu2.admin;

namespace NavigationDrawerPopUpMenu2.admin.admin_usercontrols
{
    public partial class admin_addUsers : UserControl
    {
        public admin_addUsers()
        {
            InitializeComponent();
            admin_personalInfo usd = new admin_personalInfo();
            mainGrid.Children.Add(usd);
        }

        private void listViewProgress_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            mainGrid.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Personal":
                    usc = new admin_personalInfo();
                    mainGrid.Children.Add(usc);
                    break;
                case "Business Info":
                    usc = new admin_businessInfo();
                    mainGrid.Children.Add(usc);
                    break;
            }
        }
    }
}
