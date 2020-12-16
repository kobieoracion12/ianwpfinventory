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
    /// Interaction logic for report_sales.xaml
    /// </summary>
    public partial class report_sales : Window
    {
        Database conn = new Database();
        usc_sales_inventory usc_sales;
        string reportToPrint;
        public report_sales(usc_sales_inventory s, string report1)
        {
            InitializeComponent();
            usc_sales = s;
            reportToPrint = report1;
        }

        // Print Preview
        public void printPreview()
        {
            string formattedFrom, formattedTo, brandSort, statusSort;
            string query = "";

            // Init selected dates from calendar
            DateTime? selectedDateFrom = usc_sales.sortCalendarFrom.SelectedDate;
            DateTime? selectedDateTo = usc_sales.sortCalendarTo.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                brandSort = usc_sales.sortBrand.Text;
                statusSort = usc_sales.sortStatus.Text;
                if (brandSort == "Select")
                {
                    brandSort = null;
                }
                // Making a format and getting the value of datepicker to string
                formattedFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                formattedTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                ReportDataSource rptDataSource;

                try
                {

                    this.ReportViewerSales.LocalReport.DataSources.Clear();
                    ReportViewerSales.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.ReportSale.rdlc";
                    DataSet1 ds = new DataSet1();

                    conn.Open();
                    if (reportToPrint == "Select")
                    {
                        query = "SELECT * FROM datasalesinventory";
                    }
                    else if (reportToPrint == "Sort")
                    {
                         query = "SELECT * FROM datasalesinventory WHERE salesBrand LIKE '%" + brandSort + "%' AND salesStatus LIKE '%" + statusSort + "%' AND salesDate BETWEEN '" + formattedFrom + "' AND '" + formattedTo + "' "; // Sort base on the query
                    }

                    MySqlDataAdapter da = conn.DataAdapter(query);
                    da.Fill(ds.Tables["dtSold"]);
                    conn.Close();

                    rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                    this.ReportViewerSales.LocalReport.DataSources.Add(rptDataSource);
                    ReportViewerSales.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                    ReportViewerSales.ZoomMode = ZoomMode.Percent;
                    ReportViewerSales.ZoomPercent = 100;

                }
                catch (Exception x)
                {
                    conn.Close();
                    MessageBox.Show("Print Preview, "+x.Message, "Preview Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
