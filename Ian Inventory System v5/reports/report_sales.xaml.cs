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
        Store store = new Store();
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
            string doaFrom, doaTo, brand, category, status;
            string query = "";
            // Init selected dates from calendar
            DateTime? selectedDateFrom = usc_sales.sortCalendarFrom.SelectedDate;
            DateTime? selectedDateTo = usc_sales.sortCalendarTo.SelectedDate;

            try
            {

                if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
                {
                    // Making a format and getting the value of datepicker to string
                    usc_sales.doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                    usc_sales.doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                    brand = usc_sales.sortBrand.Text;
                    category = usc_sales.sortCategory.Text;
                    status = usc_sales.sortStatus.Text;
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

                    ReportDataSource rptDataSource;


                    this.ReportViewerSales.LocalReport.DataSources.Clear();
                    ReportViewerSales.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.ReportSale.rdlc";
                    DataSet1 ds = new DataSet1();

                    conn.Open(); // Open Connection
                    if (reportToPrint == "Select")
                    {
                        query = "SELECT * FROM datasalesinventory ORDER BY refNo DESC";
                    }
                    else if (reportToPrint == "Sort")
                    {
                        query = "SELECT * FROM datasalesinventory WHERE salesBrand LIKE '%" + brand + "%' AND salesCategory LIKE '%" + category + "%' AND salesStatus LIKE '%" + status + "%' AND salesDate BETWEEN '" + usc_sales.doaFrom + "' AND '" + usc_sales.doaTo + "' ORDER BY salesItem ASC "; // Sort base on the query
                    }

                    MySqlDataAdapter da = conn.DataAdapter(query);
                    da.Fill(ds.Tables["dtSold"]);
                    conn.Close();


                    ReportParameter pStore = new ReportParameter("pStore", store.storeName(conn));
                    ReportParameter pAddress = new ReportParameter("pAddress", store.storeAddress(conn));

                    ReportViewerSales.LocalReport.SetParameters(pStore);
                    ReportViewerSales.LocalReport.SetParameters(pAddress);

                    rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                    this.ReportViewerSales.LocalReport.DataSources.Add(rptDataSource);
                    ReportViewerSales.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                    ReportViewerSales.ZoomMode = ZoomMode.Percent;
                    ReportViewerSales.ZoomPercent = 100;
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message + ", Something went wrong", "Sales Report", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            }
        }
    }

