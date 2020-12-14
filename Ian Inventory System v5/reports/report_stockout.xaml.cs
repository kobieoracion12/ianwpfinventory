﻿using NavigationDrawerPopUpMenu2.classes;
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
    /// Interaction logic for report_stockout.xaml
    /// </summary>
    public partial class report_stockout : Window
    {
        Database conn = new Database();
        UserControlCheckout usc_stockout;
        public report_stockout(UserControlCheckout usc_stockout)
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
                ReportViewerStockOut.LocalReport.ReportEmbeddedResource = "NavigationDrawerPopUpMenu2.Reportstockout.rdlc";
                DataSet1 ds = new DataSet1();

                conn.Open();
                string query = "SELECT * FROM stock_out WHERE stockoutTransNo='" + usc_stockout.orderNo.Text + "' AND stockoutStatus = 'Stock Out'";
                MySqlDataAdapter da = conn.DataAdapter(query);
                da.Fill(ds.Tables["dtStockout"]);
                conn.Close();

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtStockout"]);
                this.ReportViewerStockOut.LocalReport.DataSources.Add(rptDataSource);
                ReportViewerStockOut.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                ReportViewerStockOut.ZoomMode = ZoomMode.Percent;
                ReportViewerStockOut.ZoomPercent = 100;


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Receipt Printing Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
