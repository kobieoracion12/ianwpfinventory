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
using NavigationDrawerPopUpMenu2.reports;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_stockout_history : UserControl
    {
        Database conn = new Database();
        public usc_stockout_history()
        {
            InitializeComponent();
            loadDataForRecord();
            getLastDate();
            cbStatus();
        }

        // Listview History
        public void loadDataForRecord()
        {
            try
            {
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM stock_out WHERE stockoutStatus = 'Stock Out' ORDER BY stockoutDate DESC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("stock_out");
                // Fill the datatable
                adapter.Fill(dt);
                listViewRecords.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                adapter.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Load Data", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Fill the DatePicker with the first date available in database
        public void getLastDate()
        {
            try
            {
                conn.Open();
                string lastDate = "SELECT stockoutDate FROM stock_out ORDER BY stockoutDate ASC LIMIT 1";
                conn.query(lastDate);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    string[] row = { drd.GetString(0) };
                    sortDOAfrom.Text = row[0];
                }

                drd.Close();
                drd.Dispose();
                conn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Fills the Brand ComboBox with exisiting Category Data from Database
        public void cbStatus()
        {
            conn.Open();
            try
            {
                string query = "SELECT DISTINCT stockoutStatus FROM stock_out ORDER BY stockoutStatus ASC";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    sortStatus.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        // Sort Button
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            string doaFrom, doaTo, status;
            // Init selected dates from calendar
            DateTime? selectedDateFrom = sortDOAfrom.SelectedDate;
            DateTime? selectedDateTo = sortDOAto.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                // Making a format and getting the value of datepicker to string
                doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                status = sortStatus.Text;
                if (status == "Select")
                {
                    status = null;
                }
                try
                {
                    conn.Open(); // Open Connection
                    string query = "SELECT * FROM stock_out WHERE stockoutStatus LIKE '%" + status + "%' AND stockoutDate BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY stockoutItem ASC "; // Sort base on the query
                    conn.query(query);  // Command Database
                    conn.execute(); // Execute Non Query
                    MySqlDataAdapter adapter = conn.adapter(); // adapter
                    System.Data.DataTable dt = new System.Data.DataTable("stock_out"); // Make a datatable reference
                    adapter.Fill(dt);  // Fill the datatable with data
                    listViewRecords.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);

                    adapter.Dispose(); // Dispose Adapter
                    conn.Close(); // Close Connection
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Refresh Button
        private void refreshItem_Click(object sender, RoutedEventArgs e)
        {
            loadDataForRecord();
            sortStatus.Text = "Select";
        }

        // Search Function
        private void tbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            conn.Close(); // Close the connection first
            try
            {
                // Open Connection 
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM stock_out WHERE stockoutTransNo LIKE '%" + tbSearch.Text + "%' OR stockoutNo LIKE '%" + tbSearch.Text + "%' OR stockoutItem LIKE '%" + tbSearch.Text + "%' OR stockoutPrice LIKE '%" + tbSearch.Text + "%' OR stockoutStatus LIKE '%" + tbSearch.Text + "%' ORDER BY stockoutItem ASC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                System.Data.DataTable dt = new System.Data.DataTable("stock_out");
                // Fill the datatable
                adapter.Fill(dt);
                listViewRecords.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }

        // Remove Button
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbPrdId.Text == "")
            { // Check if field is empty
                MessageBox.Show("Please select one on the table cell", "Notice", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {   // Delete the product
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deleteProductItem(); // If Yes then Delete the product
                    loadDataForRecord();
                    tbSearch.Clear();
                }
            }
        }

        // Delete Function
        private void deleteProductItem()
        {
            conn.Close();
            // Delete sql statement
            string sql = "DELETE FROM stock_out WHERE stockoutId = @id";
            conn.query(sql); // Command Database
            try
            {
                conn.Open();   // Open Connection
                conn.bind("@id", tbPrdId.Text); // Bind parameter
                conn.cmd().Prepare(); // Prepare
                conn.execute(); // Execute


                MessageBox.Show("Successfully Removed"); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
