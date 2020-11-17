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
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for window_restockItem.xaml
    /// </summary>
    public partial class window_restockItem : Window
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");
        public window_restockItem()
        {
            InitializeComponent();
        }

        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;

                DataTable dt = new DataTable();
                con.Open();
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM datainventory WHERE prodNo= '" + search + "'", con);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    restockItem.Text = (myReader["prodItem"].ToString());
                    restockBrand.Text = (myReader["prodBrand"].ToString());
                    onrestockQty.Text = (myReader["prodQty"].ToString());
                    restockSRP.Text = (myReader["prodSRP"].ToString());
                    restockRP.Text = (myReader["prodRP"].ToString());
                    restockEXPD.Text = (myReader["prodEXPD"].ToString());

                }
                con.Close();
            }
        }
    }
}
