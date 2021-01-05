using NavigationDrawerPopUpMenu2.classes;
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
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.reports
{
    /// <summary>
    /// Interaction logic for report_newstoukout.xaml
    /// </summary>
    public partial class report_newstoukout : Window
    {
        Store store = new Store();
        Database conn = new Database();
        usc_user_out usc_stockout;
        public report_newstoukout(usc_user_out usc_stockout)
        {
            InitializeComponent();
            this.usc_stockout = usc_stockout;
        }

        public void printPreview()
        {

            ReportDataSource rptDataSource;
            try
            {

                this.ReportViewerStockOut.LocalReport.DataSources.Clear();
                ReportViewerStockOut.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.ReportStock.rdlc";
                DataSet1 ds = new DataSet1();

                conn.Open();
                string query = "SELECT * FROM stock_out WHERE stockoutTransNo='" + usc_stockout.orderNo.Text + "' AND stockoutStatus = 'Stock Out'";
                MySqlDataAdapter da = conn.DataAdapter(query);
                da.Fill(ds.Tables["dtStockOut"]);
                conn.Close();

                ReportParameter pStore = new ReportParameter("pStore", store.storeName(conn));
                ReportParameter pAddress = new ReportParameter("pAddress", store.storeAddress(conn));

                ReportViewerStockOut.LocalReport.SetParameters(pStore);
                ReportViewerStockOut.LocalReport.SetParameters(pAddress);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtStockOut"]);
                this.ReportViewerStockOut.LocalReport.DataSources.Add(rptDataSource);
                ReportViewerStockOut.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                ReportViewerStockOut.ZoomMode = ZoomMode.Percent;
                ReportViewerStockOut.ZoomPercent = 100;


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Stock In Report Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
