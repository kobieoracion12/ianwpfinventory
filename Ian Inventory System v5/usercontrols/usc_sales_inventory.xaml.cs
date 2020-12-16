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
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;
using Microsoft.Reporting.WinForms;
using NavigationDrawerPopUpMenu2.reports;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_sales_inventory : UserControl
    {
        Database conn = new Database();
        List<Sales> mySales = new List<Sales>();
        string reportSales;

        public usc_sales_inventory()
        {
            InitializeComponent();
            catchData();
            cbBrand();
        }

        // ListView Data
        public void catchData()
        {
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT * FROM datasalesinventory ORDER BY refNo DESC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                System.Data.DataTable dt = new System.Data.DataTable("datasalesinventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fills the Brand ComboBox with exisiting Brand Data from Database
        public void cbBrand()
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

                drd.Close();
                drd.Dispose();
                conn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        public void cbCategory()
        {

        }

        // Sort by Date FROM - Date TO 
        // Sort by Date Between Date From and Date To and Brand
        public void sortByDate()
        {
            string formattedFrom, formattedTo, brandSort, statusSort;

            // Init selected dates from calendar
            DateTime? selectedDateFrom = sortCalendarFrom.SelectedDate;
            DateTime? selectedDateTo = sortCalendarTo.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                brandSort = sortBrand.Text;
                statusSort = sortStatus.Text;
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
                    string query = "SELECT * FROM datasalesinventory WHERE salesBrand LIKE '%" + brandSort + "%' AND salesStatus LIKE '%" + statusSort + "%' AND salesDate BETWEEN '" + formattedFrom + "' AND '" + formattedTo + "' "; // Sort base on the query
                    conn.query(query);  // Command Database
                    conn.execute(); // Execute Non Query
                    MySqlDataAdapter adapter = conn.adapter(); // adapter
                    System.Data.DataTable dt = new System.Data.DataTable("datasalesinventory"); // Make a datatable reference
                    adapter.Fill(dt);  // Fill the datatable with data
                    listViewSales.ItemsSource = dt.DefaultView;
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

        // Filter Button
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            //checkSort();
            reportSales = "Sort";
            sortByDate();
        }

        // Search Function
        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
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
                System.Data.DataTable dt = new System.Data.DataTable("datainventory");
                // Fill the datatable
                adapter.Fill(dt);
                listViewSales.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Refresh Button
        private void refreshItem_Click(object sender, RoutedEventArgs e)
        {
            catchData();
            reportSales = "Select";
        }

        // Export Button
        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msg = MessageBox.Show("Do you want to export all the data before clearing them all?", "Confirmation", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (msg == MessageBoxResult.Yes)
            {
                // If Yes then Delete the Data
                exportDataToExcel();
                ClearAllDataFromDatabase();
                catchData();
            }
            else if (msg == MessageBoxResult.No)
            {
                MessageBoxResult deleteMsg = MessageBox.Show("This will clear all the data without exporting a file, Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (deleteMsg == MessageBoxResult.Yes)
                {
                    // Delete the Data
                    ClearAllDataFromDatabase();
                    catchData();
                }
            }
            else if (msg == MessageBoxResult.Cancel)
            {
                return;
            }
            else { return; }
        }

        // Export Data to Excel
        private void exportDataToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel WorkBook|*.xls";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Save to MyDocuments
            try
            {
                if (sfd.ShowDialog() == true)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Product No";
                    ws.Cells[1, 2] = "Item";
                    ws.Cells[1, 3] = "Brand";
                    //ws.Cells[1, 4] = "Date of Purchase";
                    ws.Cells[1, 4] = "RP";
                    ws.Cells[1, 5] = "Quantity";
                    ws.Cells[1, 6] = "Total";
                    int i = 2;

                    // Start a Query
                    string sql = "SELECT * FROM datasalesinventory";
                    conn.query(sql);
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                            long SalesNo = Convert.ToInt64(row[1]); // sales No
                            string SalesItem = row[2];  // Sales item
                            string SalesBrand = row[3];
                            int SalesRp = int.Parse(row[5]);
                            int SalesQty = int.Parse(row[6]);
                            int SalesTotal = int.Parse(row[7]);

                            mySales.Add(new Sales { salesNo = SalesNo, salesItem = SalesItem, salesBrand = SalesBrand, salesRP = SalesRp, salesQty = SalesQty, salesTotal = SalesTotal });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Rows", "Notice", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }

                    reader.Close();
                    reader.Dispose();
                    conn.Close();

                    // End of Query


                    //string das = listViewSales.Items[0].ToString();
                    foreach (Sales item in mySales)
                    {
                        //ws.Cells[i, 1] = (string)((DataRowView)listViewSales.SelectedItems[0])["refNo"];
                        ws.Cells[i, 1] = item.salesNo.ToString();
                        ws.Cells[i, 2] = item.salesItem;
                        ws.Cells[i, 3] = item.salesBrand;
                        ws.Cells[i, 4] = item.salesRP.ToString();
                        ws.Cells[i, 5] = item.salesQty.ToString();
                        ws.Cells[i, 6] = item.salesTotal.ToString();

                        i++;

                    } // Closing of Foreach

                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    mySales.Clear(); // Clear All Items
                    MessageBox.Show("Your data has been successfully exported", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                } // Closing of IF Statement
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Delete All From Database
        private void ClearAllDataFromDatabase()
        {
            string sql = "DELETE FROM datasalesinventory";
            conn.query(sql);

            try
            {
                conn.Open();
                conn.cmd().Prepare();
                conn.execute();
                MessageBox.Show("All data has been removed successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Reset Button
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msg = MessageBox.Show("Do you want to export all the data before clearing them all?", "Confirmation", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (msg == MessageBoxResult.Yes)
            {
                // If Yes then Delete the Data
                exportDataToExcel();
                ClearAllDataFromDatabase();
                catchData();
            }
            else if (msg == MessageBoxResult.No)
            {
                MessageBoxResult deleteMsg = MessageBox.Show("This will clear all the data without exporting a file, Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (deleteMsg == MessageBoxResult.Yes)
                {
                    // Delete the Data
                    ClearAllDataFromDatabase();
                    catchData();
                }
            }
            else if (msg == MessageBoxResult.Cancel)
            {
                return;
            }
            else { return; }
        }
    }
}
