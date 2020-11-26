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
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.admin
{
    /// <summary>
    /// Interaction logic for admin_create.xaml
    /// </summary>
    public partial class admin_create : UserControl
    {
        public string username = "";
        public string password = "";
        public string privilege = "";

        public admin_create()
        {
            InitializeComponent();
        }

        private void piNextButton_Click(object sender, RoutedEventArgs e)
        {
           

        }
    }
}
