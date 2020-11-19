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
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class UserControlCheckout : UserControl
    {
        Database conn = new Database();
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");

        public UserControlCheckout()
        {
            InitializeComponent();
        }

        public UserControlCheckout(string value)
        {
            InitializeComponent();
            this.Value = value; // Store the passed value to the variable value
        }

        public string Value { get; set; } // Create a variable to store the value


        // When Checkout loads
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            window_cashButton.myCash = cashAmount.Text;
        }

        // Add Cash
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            window_cashButton cf = new window_cashButton();
            cf.DataSent += Cf_DataSent; // Register the Event Handler - When this Event fired 'Cf_DataSent' will be called
            cf.ShowDialog();
        }


        // Event Handler to update the parent textbox
        private void Cf_DataSent(string msg)
        {
            cashAmount.Text = "₱ " + msg;
            pay_paid.Text = "₱ " + msg;
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
                        coItem.Text = (myReader["prodItem"].ToString());
                        coBrand.Text = (myReader["prodBrand"].ToString());
                        coSRP.Text = (myReader["prodSRP"].ToString());
                        coRP.Text = (myReader["prodRP"].ToString());
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

        private void coPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            int price = Convert.ToInt32(coRP.Text);
            int qty = Convert.ToInt32(coQty.Text);

            coSubtotal.Text = Convert.ToString(price * qty);
        }

        private void coSubtotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO datasalesinventory (salesNo, salesItem, salesBrand, salesDate, salesSRP, salesRP, salesQty, salesTotal) VALUES (@sNo, @sItem, @sBrand, @sDate, @sSRP, @sRP, @sQty, @sTotal);";

                cmd.Parameters.AddWithValue("@sNo", entrySearch.Text);
                cmd.Parameters.AddWithValue("@sItem", coItem.Text);
                cmd.Parameters.AddWithValue("@sBrand", coBrand.Text);
                cmd.Parameters.AddWithValue("@sSRP", coSRP.Text);
                cmd.Parameters.AddWithValue("@sRP", coRP.Text);
                cmd.Parameters.AddWithValue("@sQty", coQty.Text);
                cmd.Parameters.AddWithValue("@sTotal", coSubtotal.Text);

                string str = coDOP.Text;
                DateTime dt;
                dt = DateTime.Parse(str);
                cmd.Parameters.AddWithValue("@sDate", dt);

                cmd.Connection = con;
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Data added Sucessfully");
                    entrySearch.Text = "";
                    coItem.Text = "";
                    coBrand.Text = "";
                    coSRP.Text = "";
                    coRP.Text = "";
                    coQty.Text = "";
                    coSubtotal.Text = "";

                    entrySearch.Focus();
                }

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
