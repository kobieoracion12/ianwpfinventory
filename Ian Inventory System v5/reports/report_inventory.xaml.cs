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
    /// Interaction logic for report_inventory.xaml
    /// </summary>
    public partial class report_inventory : Window
    {
        Database conn = new Database();
        usc_parent_overviews usc_overview;
        string query = "";
        private usc_parent_overviews usc_parent_overviews;

        public report_inventory(usc_parent_overviews usc_overview)
        {
            InitializeComponent();
            this.usc_overview = usc_overview;
        }

        public void printPreview()
        {

            string doaFrom, doaTo, brand, category;
            // Init selected dates from calendar
            DateTime? selectedDateFrom = usc_overview.sortDOAfrom.SelectedDate;
            DateTime? selectedDateTo = usc_overview.sortDOAto.SelectedDate;

            if (selectedDateFrom.HasValue || selectedDateTo.HasValue)
            {
                // Making a format and getting the value of datepicker to string
                doaFrom = selectedDateFrom.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                doaTo = selectedDateTo.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

                brand = usc_overview.sortBrand.Text;
                category = usc_overview.sortCategory.Text;
                if (brand == "Select")
                {
                    brand = null;
                }
                else if (category == "Select")
                {
                    category = null;
                }
                ReportDataSource rptDataSource;
                try
                {


                    this.ReportViewerInventory.LocalReport.DataSources.Clear();
                    ReportViewerInventory.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.Reportinventory.rdlc";
                    DataSet1 ds = new DataSet1();

                    conn.Open();

                    if (usc_overview.filter == "Select")
                    {
                        query = "SELECT * FROM datainventory ORDER BY prodItem ASC";
                    }
                    else if (usc_overview.filter == "Sort")
                    {
                        query = "SELECT * FROM datainventory WHERE prodBrand LIKE '%" + brand + "%' AND prodCategory LIKE '%" + category + "%' AND prodDOA BETWEEN '" + doaFrom + "' AND '" + doaTo + "' ORDER BY prodItem ASC "; // Sort base on the query
                    }

                    MySqlDataAdapter da = conn.DataAdapter(query);
                    da.Fill(ds.Tables["dtInventory"]);
                    conn.Close();

                    rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                    this.ReportViewerInventory.LocalReport.DataSources.Add(rptDataSource);
                    ReportViewerInventory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                    ReportViewerInventory.ZoomMode = ZoomMode.Percent;
                    ReportViewerInventory.ZoomPercent = 100;


                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message + ", Try again later", "Receipt Printing Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
        }
    }
}
