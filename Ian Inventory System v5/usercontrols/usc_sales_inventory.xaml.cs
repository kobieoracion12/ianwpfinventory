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
        Sales sales = new Sales();
        List<Sales> mySales = new List<Sales>();
        string reportSales = "Select";

        public usc_sales_inventory()
        {
            InitializeComponent();
            catchData();
            cbBrand();
            cbCategory();
            getLastDate();
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
            conn.Close();
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT salesBrand FROM datasalesinventory ORDER BY salesBrand ASC";
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

        // Fills the Category ComboBox with existing Category
        public void cbCategory()
        {
            conn.Close();
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT salesCategory FROM datasalesinventory ORDER BY salesCategory ASC";
                conn.query(query);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    sortCategory.Items.Add(drd.GetString(0).ToString());
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

        // Fill the DatePicker with the first date available in database
        public void getLastDate()
        {
            try
            {
                conn.Open();
                string lastDate = "SELECT salesDate FROM datasalesinventory ORDER BY salesDate ASC LIMIT 1";
                conn.query(lastDate);
                conn.execute();
                MySqlDataReader drd = conn.read();

                while (drd.Read())
                {
                    string[] row = { drd.GetString(0) };
                    sortCalendarFrom.Text = row[0];
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

        // Sort by Date FROM - Date TO 
        // Sort by Date Between Date From and Date To and Brand
        public string doaFrom, doaTo, brand, category, status;
        public void sortByDate()
        {
            // Init selected dates from calendar
            DateTime? selectedDateFrom = sortCalendarFrom.SelectedDate;
            DateTime? selectedDateTo = sortCalendarTo.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                // Making a format and getting the value of datepicker to string
                doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                brand = sortBrand.Text;
                category = sortCategory.Text;
                status = sortStatus.Text;
                if (brand == "Select")
                {
                    brand = null;
                }
                if (category == "Select")
                {
                    category = null;
                }
                if (status == "Select")
                {
                    status = null;
                }

                try
                {
                    conn.Open(); // Open Connection
                    string query = "SELECT * FROM datasalesinventory WHERE salesBrand LIKE '%" + brand + "%' AND salesCategory LIKE '%" + category + "%' AND salesStatus LIKE '%" + status + "%' AND salesDate BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY salesItem ASC "; // Sort base on the query
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
            sortBrand.Text = "Select";
            sortCategory.Text = "Select";
            sortStatus.Text = "Select";
            brand = null;
            category = null;
            status = null;
        }

        // Export Button
        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            report_sales rptsales = new report_sales(this, reportSales);
            rptsales.printPreview();
            rptsales.ShowDialog();
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
