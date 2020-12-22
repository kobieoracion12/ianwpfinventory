﻿using System;
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
using NavigationDrawerPopUpMenu2.classes;
using System.Data;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_receipt.xaml
    /// </summary>
    public partial class win_receipt : Window
    {
        Database conn = new Database();
        win_pos win_pos;
        Store store = new Store();
        public win_receipt(win_pos winPOS)
        {
            InitializeComponent();
            win_pos = winPOS;
            //ReportViewerDemo.RenderingComplete += new RenderingCompleteEventHandler(RenderingCompleteEventHandler);
        }

        // When Receipt Report Loads
        private void RenderingCompleteEventHandler(object sender, RenderingCompleteEventArgs e)
        {   // If Report Viewer is Loaded 
            // Do Something
            /*ReportViewerDemo.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            ReportViewerDemo.PrintDialog();*/
        }

        public void loadReport()
        {

            ReportDataSource rptDataSource;
            try
            {

                this.ReportViewerDemo.LocalReport.DataSources.Clear();
                ReportViewerDemo.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.Report1.rdlc";
                DataSet1 ds = new DataSet1();

                conn.Open();
                string query = "SELECT * FROM datasalesinventory WHERE salesTransNo='"+win_pos.orderNo.Text+ "' AND salesStatus = 'Pending'";
                MySqlDataAdapter da = conn.DataAdapter(query);
                da.Fill(ds.Tables["dtSold"]);
                conn.Close();

                // Parameters
                ReportParameter pStoreName = new ReportParameter("pStoreName", store.storeName(conn));
                ReportParameter pStoreAddress = new ReportParameter("pStoreAddress", store.storeAddress(conn));
                ReportParameter pTin = new ReportParameter("pTin","Tin: "+ store.storeTin(conn));
                ReportParameter pSerialNumber = new ReportParameter("pSerialNumber","Serial No.: "+ store.storeSN(conn));
                ReportParameter pMin = new ReportParameter("pMin","Min: "+ store.storeMin(conn));
                ReportParameter pCashierName = new ReportParameter("pCashierName","Cashier: "+win_pos.cashierName.Text);
                ReportParameter pTransNo = new ReportParameter("pTransNo","Trans #: "+ win_pos.orderNo.Text);
                ReportParameter pSubTotal = new ReportParameter("pSubTotal", win_pos.pay_subtotal.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", win_pos.pay_total.Text);
                ReportParameter pCash = new ReportParameter("pCash", win_pos.pay_paid.Text);
                ReportParameter pChange = new ReportParameter("pChange", win_pos.pay_due.Text);
                ReportParameter pTax = new ReportParameter("pTax", win_pos.pay_tax.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", win_pos.discount);
                ReportParameter pVatable = new ReportParameter("pVatable", win_pos.sumOfSalesTotals());

                // Set Parameters
                ReportViewerDemo.LocalReport.SetParameters(pStoreName);
                ReportViewerDemo.LocalReport.SetParameters(pStoreAddress);
                ReportViewerDemo.LocalReport.SetParameters(pTin);
                ReportViewerDemo.LocalReport.SetParameters(pSerialNumber);
                ReportViewerDemo.LocalReport.SetParameters(pMin);
                ReportViewerDemo.LocalReport.SetParameters(pCashierName);
                ReportViewerDemo.LocalReport.SetParameters(pTransNo);
                ReportViewerDemo.LocalReport.SetParameters(pSubTotal);
                ReportViewerDemo.LocalReport.SetParameters(pTotal);
                ReportViewerDemo.LocalReport.SetParameters(pCash);
                ReportViewerDemo.LocalReport.SetParameters(pChange);
                ReportViewerDemo.LocalReport.SetParameters(pTax);
                ReportViewerDemo.LocalReport.SetParameters(pDiscount);
                ReportViewerDemo.LocalReport.SetParameters(pVatable);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                this.ReportViewerDemo.LocalReport.DataSources.Add(rptDataSource);
                ReportViewerDemo.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                ReportViewerDemo.ZoomMode = ZoomMode.Percent;
                ReportViewerDemo.ZoomPercent = 100;


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Receipt Printing Failed",  MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
