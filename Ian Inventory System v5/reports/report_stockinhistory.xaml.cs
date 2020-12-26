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
using Microsoft.Reporting.WinForms;
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.reports
{
    /// <summary>
    /// Interaction logic for report_stockinhistory.xaml
    /// </summary>
    public partial class report_stockinhistory : Window
    {
        Store store = new Store();
        Database conn = new Database();
        usc_stockout usc_stockout;
        string query = "";
        string reportToPrint;
        public report_stockinhistory(usc_stockout usc_stockout, string report1)
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

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                // Making a format and getting the value of datepicker to string
                doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                ReportDataSource rptDataSource;
                try
                {
                    this.ReportViewerStockInHistory.LocalReport.DataSources.Clear();
                    ReportViewerStockInHistory.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.Reportstockinhistory.rdlc";
                    DataSet1 ds = new DataSet1();

                    conn.Open(); // Open Connection
                    if (reportToPrint == "Select")
                    {
                        query = "SELECT * FROM stock_in WHERE stockinStatus = 'Stock In' ORDER BY stockinDate DESC";
                    }
                    else if (reportToPrint == "Sort")
                    {
                        query = "SELECT * FROM stock_in WHERE stockinDate BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY stockinDate DESC "; // Sort base on the query
                    }

                    MySqlDataAdapter da = conn.DataAdapter(query);
                    da.Fill(ds.Tables["dtStockin"]);
                    conn.Close(); // Close Conn

                    rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtStockin"]);
                    this.ReportViewerStockInHistory.LocalReport.DataSources.Add(rptDataSource);
                    ReportViewerStockInHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                    ReportViewerStockInHistory.ZoomMode = ZoomMode.Percent;
                    ReportViewerStockInHistory.ZoomPercent = 100;

                }
                catch (Exception x)
                {
                    conn.Close();
                    MessageBox.Show(x.Message + ", Try again later", "Stock In Report Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
