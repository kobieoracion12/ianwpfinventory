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
using NavigationDrawerPopUpMenu2;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class window_addItem : Window
    {
       
        public window_addItem()
        {
            InitializeComponent();
        }

        private void addItemSubmit_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");
            try
            {
                if (tbProdNo.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdItem.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdBrand.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdSRP.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdRP.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdDOA.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else if (tbProdEXPD.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodSRP, prodRP, prodDOA, prodEXPD) VALUES (@pn, @pi, @pb, @pp, @pq, @pdoa, @pexpd);";

                    cmd.Parameters.AddWithValue("@pn", tbProdNo.Text);
                    cmd.Parameters.AddWithValue("@pi", tbProdItem.Text);
                    cmd.Parameters.AddWithValue("@pb", tbProdBrand.Text);
                    cmd.Parameters.AddWithValue("pp", tbProdSRP.Text);
                    cmd.Parameters.AddWithValue("pq", tbProdRP.Text);

                    string str = tbProdEXPD.Text;
                    DateTime dt;
                    dt = DateTime.Parse(str);

                    cmd.Parameters.AddWithValue("pdoa", DateTime.Now);
                    cmd.Parameters.AddWithValue("@pexpd", dt);
                    cmd.Connection = con;
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        MessageBox.Show("Data added Sucessfully");
                        tbProdNo.Text = "";
                        tbProdItem.Text = "";
                        tbProdBrand.Text = "";
                        tbProdSRP.Text = "";
                        tbProdRP.Text = "";
                        tbProdDOA.Text = "";
                        tbProdEXPD.Text = "";
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addItemCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
