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
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.windows
{
    public partial class window_restockItem : Window
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");
        Database conn = new Database();
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

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        restockItem.Text = (myReader["prodItem"].ToString());
                        restockBrand.Text = (myReader["prodBrand"].ToString());
                        onrestockQty.Text = (myReader["prodQty"].ToString());
                        restockSRP.Text = (myReader["prodSRP"].ToString());
                        restockRP.Text = (myReader["prodRP"].ToString());
                        restockEXPD.Text = (myReader["prodEXPD"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry!");
                    entrySearch.Text = "";
                }
                
                con.Close();
            }
        }

        private void submitBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE datainventory SET prodItem = @Itm, prodBrand = @Brnd, prodItem = @Itm, prodQty = @Qty, prodSRP = @SRP, prodRP = @RP, prodDOA = @DOA, prodEXPD = @EXPD WHERE prodNo = @No", con))
                {
                    cmd.Parameters.AddWithValue("@No", entrySearch.Text);
                    cmd.Parameters.AddWithValue("@Itm", restockItem.Text);
                    cmd.Parameters.AddWithValue("@Brnd", restockBrand.Text);
                    cmd.Parameters.AddWithValue("@Qty", restockQty.Text);
                    cmd.Parameters.AddWithValue("@SRP", restockSRP.Text);
                    cmd.Parameters.AddWithValue("@RP", restockRP.Text);
                    cmd.Parameters.AddWithValue("@DOA", DateTime.Now);

                    string str = restockEXPD.Text;
                    DateTime dt;
                    dt = DateTime.Parse(str);

                    cmd.Parameters.AddWithValue("@EXPD", dt);
                    cmd.Connection = con;
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        MessageBox.Show("Stocks Updated!");
                        restockItem.Text = "";
                        restockBrand.Text = "";
                        restockQty.Text = "";
                        restockSRP.Text = "";
                        restockRP.Text = "";
                        restockDOA.Text = "";
                        restockEXPD.Text = "";
                    }
                    con.Close();

                    UserControlInventory uci = new UserControlInventory();
                    uci.catchData();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void submitCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
