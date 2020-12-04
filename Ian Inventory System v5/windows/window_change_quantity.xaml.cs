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

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for window_change_quantity.xaml
    /// </summary>
    public partial class window_change_quantity : Window
    {
        Database conn = new Database();
        string transNo;
        string salesItem;
        string prodQty;
        win_pos win_pos;
        public window_change_quantity(win_pos winPOS, string trans_no, string sales_item, string prod_qty)
        {
            InitializeComponent();
            win_pos = winPOS;

            transNo = trans_no;
            salesItem = sales_item;
            prodQty = prod_qty;
        }

        // IF PRESS ENTER
        private void txtQtyChange_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                
                    conn.Open();
                    string query = "UPDATE datasalesinventory SET salesQty = '"+ txtQtyChange.Text + "' WHERE salesTransNo = '" + win_pos.orderNo.Text + "' AND salesItem = '" + salesItem + "' ";
                    conn.query(query);
                    conn.execute();

                    MessageBox.Show("Quantity Changed");
                    conn.Close();
                    this.Close(); // Close
                    win_pos.catchData();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}