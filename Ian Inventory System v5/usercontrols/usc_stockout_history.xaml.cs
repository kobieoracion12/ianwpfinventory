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
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_stockout_history : UserControl
    {
        Database conn = new Database();
        Stock_Out stockout = new Stock_Out();
        List<Stock_Out> myStockout = new List<Stock_Out>();
        string reportToPrint = "Select";
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
                System.Data.DataTable dt = new System.Data.DataTable("stock_out");
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
                conn.Close();
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
                conn.Close();
                MessageBox.Show(x.Message);
            }

        }

        // Sort Button
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            string doaFrom, doaTo, status;
            reportToPrint = "Sort";
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
                    conn.Close();
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Refresh Button
        private void refreshItem_Click(object sender, RoutedEventArgs e)
        {
            loadDataForRecord();
            reportToPrint = "Select";
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
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
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


                MessageBox.Show("Successfully Removed", "Removed", MessageBoxButton.OK, MessageBoxImage.Information); // Show Dialog Succes

                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // Export Button
        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            report_stockouthistory rptstockout = new report_stockouthistory(this, reportToPrint);
            rptstockout.printPreview();
            rptstockout.ShowDialog();
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
                    ws.Cells[1, 1] = "Stock out #";
                    ws.Cells[1, 2] = "Item No";
                    ws.Cells[1, 3] = "Item";
                    //ws.Cells[1, 4] = "Date of Purchase";
                    ws.Cells[1, 4] = "Quantity";
                    ws.Cells[1, 5] = "Price List";
                    ws.Cells[1, 6] = "Date";
                    int i = 2;

                    // Start a Query
                    string sql = "SELECT * FROM stock_out";
                    conn.query(sql);
                    conn.Open();
                    MySqlDataReader reader = conn.read();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string stockoutTransNo = reader["stockoutTransNo"].ToString();
                            string stockoutNo = reader["stockoutNo"].ToString();
                            string stockoutItem = reader["stockoutItem"].ToString();
                            string stockoutQty = reader["stockoutQty"].ToString();
                            string stockoutPrice = reader["stockoutPrice"].ToString();
                            string stockoutDate = reader["stockoutDate"].ToString();


                            myStockout.Add(new Stock_Out { stockoutTransNo = stockoutTransNo, stockoutNo = stockoutNo, stockoutItem = stockoutItem, stockoutQty = stockoutQty, stockoutPrice = stockoutPrice, stockoutDate = stockoutDate });
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
                    foreach (Stock_Out item in myStockout)
                    {
                        //ws.Cells[i, 1] = (string)((DataRowView)listViewSales.SelectedItems[0])["refNo"];
                        ws.Cells[i, 1] = item.stockoutTransNo;
                        ws.Cells[i, 2] = item.stockoutNo;
                        ws.Cells[i, 3] = item.stockoutItem;
                        ws.Cells[i, 4] = item.stockoutQty;
                        ws.Cells[i, 5] = item.stockoutPrice;
                        ws.Cells[i, 6] = item.stockoutDate;

                        i++;

                    } // Closing of Foreach

                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    myStockout.Clear(); // Clear All Items
                    MessageBox.Show("Your data has been successfully exported as an excel file", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                } // Closing of IF Statement
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Delete All From Database
        private void ClearAllDataFromDatabase()
        {
            string sql = "DELETE FROM stock_out";
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
                conn.Close();
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
                loadDataForRecord();
            }
            else if (msg == MessageBoxResult.No)
            {
                MessageBoxResult deleteMsg = MessageBox.Show("This will clear all the data without exporting a file, Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (deleteMsg == MessageBoxResult.Yes)
                {
                    // Delete the Data
                    ClearAllDataFromDatabase();
                    loadDataForRecord();
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
