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
        
        public int subtotal = 0;
        public int vat = 0;
        public int total = 0;
        public int due = 0;
        public int paid = 0;

        public UserControlCheckout()
        {
            InitializeComponent();
            fetchinVoice();
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
            paid = Convert.ToInt32(msg);
            cashAmount.Text = Convert.ToString(paid);
            pay_paid.Text = Convert.ToString(paid);

            pay_due.Text = Convert.ToString(paid - total);
        }

        public void fetchinVoice()
        {
            try
            {
                conn.Open();
                string query = "SELECT refNo, salesItem, salesRP, salesQty, salesTotal, salesDate FROM datasalesinventory ORDER BY refNo DESC";
                conn.query(query);
                conn.execute();
                MySqlDataAdapter adapter = conn.adapter();
                DataTable dt = new DataTable("datasalesinventory");
                adapter.Fill(dt);
                listViewinVoice.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Barcode Search Function
        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Barcode Text Changed
            if (entrySearch.Text.Length > 0)
            {
                string search = entrySearch.Text;
                string query = "SELECT prodItem, prodBrand, prodSRP, prodRP FROM datainventory WHERE prodNo= '" + search + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    coItem.Text = dr.GetValue(0).ToString();
                    coBrand.Text = dr.GetValue(1).ToString();
                    coSRP.Text = dr.GetValue(2).ToString();
                    coRP.Text = dr.GetValue(3).ToString();
                }

                // Closes the reader so the next query will work
                dr.Close();

                // Multiply the Price and Quantity
                if (coRP.Text.Length > 0)
                {
                    cashButton.IsEnabled = true;

                    int rp = Convert.ToInt32(coRP.Text);
                    int qty = Convert.ToInt32(coQty.Text);
                    int sub = rp * qty;

                    total += vat + sub;

                    coSubtotal.Text = Convert.ToString(sub);
                    pay_subtotal.Text = Convert.ToString(subtotal + sub);
                    pay_total.Text = Convert.ToString(total);


                    // Adds the data to the datasalesinventory
                    if (coSubtotal.Text.Length > 0)
                    {
                        try
                        {
                            MySqlCommand insertQuery = new MySqlCommand();
                            cmd.CommandText = "INSERT INTO datasalesinventory (salesNo, salesItem, salesBrand, salesSRP, salesRP, salesQty, salesTotal, salesDate) VALUES (@coNo, @coIt, @coBr, @coSRPs, @coRPs, @coQtys, @coSub, @coDOPs);";

                            cmd.Parameters.AddWithValue("@coNo", entrySearch.Text);
                            cmd.Parameters.AddWithValue("@coIt", coItem.Text);
                            cmd.Parameters.AddWithValue("@coBr", coBrand.Text);
                            cmd.Parameters.AddWithValue("@coSRPs", coSRP.Text);
                            cmd.Parameters.AddWithValue("@coRPs", coRP.Text);
                            cmd.Parameters.AddWithValue("@coQtys", coQty.Text);
                            cmd.Parameters.AddWithValue("@coSub", coSubtotal.Text);

                            string str = coDOP.Text;
                            DateTime dt;
                            dt = DateTime.Parse(str);

                            cmd.Parameters.AddWithValue("@coDOPs", dt);
                            int a = cmd.ExecuteNonQuery();

                            // Checks if the data in successfuly stored
                            if (a == 1)
                            {
                                MessageBox.Show("Data added Sucessfully");
                                fetchinVoice();
                                entrySearch.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Invalid Entry!");
                                entrySearch.Text = "";
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                    }
                }
                con.Close();
            }
            
        }
    }
}
