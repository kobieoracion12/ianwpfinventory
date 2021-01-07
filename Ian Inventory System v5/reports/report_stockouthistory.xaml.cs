using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;
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

namespace NavigationDrawerPopUpMenu2.reports
{
    /// <summary>
    /// Interaction logic for report_stockouthistory.xaml
    /// </summary>
    public partial class report_stockouthistory : Window
    {
        Store store = new Store();
        Database conn = new Database();
        usc_stockout_history usc_stockout;
        string query = "";
        string reportToPrint;
        public report_stockouthistory(usc_stockout_history usc_stockout, string report1)
        {
            InitializeComponent();
            this.usc_stockout = usc_stockout;
            reportToPrint = report1;
        }

        public void printPreview()
        {
            string doaFrom, doaTo;
            // Init selected dates from calendar
            DateTime? selectedDateFrom = usc_stockout.sortDOAfrom.SelectedDate;
            DateTime? selectedDateTo = usc_stockout.sortDOAto.SelectedDate;
            try
            {
                if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
                {
                    // Making a format and getting the value of datepicker to string
                    doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                    doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                    ReportDataSource rptDataSource;

                    this.ReportViewerStockOutHistory.LocalReport.DataSources.Clear();
                    ReportViewerStockOutHistory.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.ReportstockoutHistory.rdlc";
                    DataSet1 ds = new DataSet1();

                    conn.Open(); // Open Connection
                    if (reportToPrint == "Select")
                    {
                        query = "SELECT * FROM stock_out WHERE stockoutStatus = 'Stock Out' ORDER BY stockoutItem ASC";
                    }
                    else if (reportToPrint == "Sort")
                    {
                        query = "SELECT * FROM stock_out WHERE stockoutDate BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY stockoutItem ASC "; // Sort base on the query
                    }

                    MySqlDataAdapter da = conn.DataAdapter(query);
                    da.Fill(ds.Tables["dtStockOut"]);
                    conn.Close(); // Close Conn

                    ReportParameter pStore = new ReportParameter("pStore", store.storeName(conn));
                    ReportParameter pAddress = new ReportParameter("pAddress", store.storeAddress(conn));

                    rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtStockOut"]);
                    this.ReportViewerStockOutHistory.LocalReport.DataSources.Add(rptDataSource);
                    ReportViewerStockOutHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                    ReportViewerStockOutHistory.ZoomMode = ZoomMode.Percent;
                    ReportViewerStockOutHistory.ZoomPercent = 100;
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message + ", Try again later", "Stock In Report Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
