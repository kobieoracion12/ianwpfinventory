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
using NavigationDrawerPopUpMenu2.classes;

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
            Database con = new Database();
            try
            {
                if (tbProdNo.Text == "" || tbProdItem.Text == "" || tbProdBrand.Text == "" || tbProdQty.Text == "" || tbProdSRP.Text == "" || tbProdRP.Text == "" || tbProdDOA.Text == "" || tbProdEXPD.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodQty, prodSRP, prodRP, prodDOA, prodEXPD) VALUES (@pn, @pi, @pb, @py, @pp, @pq, @pdoa, @pexpd);";

                    con.query(query);

                    con.bind("@pn", tbProdNo.Text);
                    con.bind("@pi", tbProdItem.Text);
                    con.bind("@pb", tbProdBrand.Text);
                    con.bind("@py", tbProdQty.Text);
                    con.bind("@pp", tbProdSRP.Text);
                    con.bind("@pq", tbProdRP.Text);

                    string str = tbProdEXPD.Text;
                    DateTime dt = DateTime.Parse(str);

                    con.bind("@pdoa", DateTime.Now);
                    con.bind("@pexpd", dt);
                    int a = con.execute();

                    if (a == 1)
                    {
                        MessageBox.Show("Data added Sucessfully");
                        tbProdNo.Text = "";
                        tbProdItem.Text = "";
                        tbProdBrand.Text = "";
                        tbProdQty.Text = "";
                        tbProdSRP.Text = "";
                        tbProdRP.Text = "";
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
