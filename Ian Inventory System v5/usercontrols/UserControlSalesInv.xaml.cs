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

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    /// <summary>
    /// Interaction logic for UserControlSalesInv.xaml
    /// </summary>
    public partial class UserControlSalesInv : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=ianinventory;database=iantestinventory; password='C73DPJxyXICd4Mjq'");
        Database conn = new Database();
        public UserControlSalesInv()
        {
            InitializeComponent();
            catchData();
            cbContents();
        }

        // ListView Data
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datasalesinventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fills the Brand ComboBox with exisiting Brand Data from Database
        public void cbContents ()
        {
            conn.Open();
            try
            {
                string query = "SELECT DISTINCT salesBrand FROM datasalesinventory";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    this.sortBrand.Items.Add(drd.GetString(0).ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            conn.Close();
        }

        // Sort|Filter Button
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            sortByDate();
        }

        // Sort by Date FROM - Date TO 
        // Sort by Date Between Date From and Date To and Brand
        public void sortByDate()
        {
            string formattedFrom, formattedTo, brandSort;

            // Init selected dates from calendar
            DateTime? selectedDateFrom = sortCalendarFrom.SelectedDate;
            DateTime? selectedDateTo = sortCalendarTo.SelectedDate;

            if (selectedDateFrom.HasValue && selectedDateTo.HasValue)
            {
                brandSort = sortBrand.Text;
                if (brandSort == "Select")
                {
                    brandSort = null;
                }
                // Making a format and getting the value of datepicker to string
                formattedFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                formattedTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                try
                {
                    conn.Open(); // Open Connection
                    string query = "SELECT * FROM datasalesinventory WHERE salesBrand LIKE '%" + brandSort + "%' AND salesDate BETWEEN '" + formattedFrom + "' AND '" + formattedTo + "' "; // Sort base on the query
                    conn.query(query);  // Command Database
                    conn.execute(); // Execute Non Query
                    MySqlDataAdapter adapter = conn.adapter(); // adapter
                    DataTable dt = new DataTable("datasalesinventory"); // Make a datatable reference
                    adapter.Fill(dt);  // Fill the datatable with data
                    listViewSales.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    conn.Close(); // Clone Connection
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

        }

        // Clear Button
        private void sortClear_Click(object sender, RoutedEventArgs e)
        {
            catchData();
        }

        private void coItem_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

       // Real-time Search Function
        private void searchSort_TextChanged(object sender, TextChangedEventArgs e)
        {
            conn.Close(); // Close the connection first
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory WHERE salesNo LIKE '%" + searchSort.Text + "%' OR salesItem LIKE '%" + searchSort.Text + "%' OR salesBrand LIKE '%" + searchSort.Text + "%' OR salesSRP LIKE '%" + searchSort.Text + "%' OR salesRP LIKE '%" + searchSort.Text + "%'";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
