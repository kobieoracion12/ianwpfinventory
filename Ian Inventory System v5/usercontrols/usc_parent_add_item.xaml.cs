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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_parent_add_item : UserControl
    {
        Database con = new Database();
        Checkout checkout = new Checkout();

        public usc_parent_add_item()
        {
            InitializeComponent();
            checkBarcode.Focus();
            cbBrand();
        }

        // Barcode Scanner Function
        private void checkBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string search = checkBarcode.Text;
                string scan = "SELECT prodNo FROM datainventory WHERE prodNo= '" + search + "'";
                con.query(scan);
                try
                {
                    con.Open();
                    MySqlDataReader reader = con.read();
                    if (reader.Read())
                    {
                        string[] row = { reader.GetString(0) };
                        checker.Text = row[0];
                        if (checker.Text == search)
                        {
                            var ans = MessageBox.Show("Item Already Exist");
                            Clear();
                            con.Close();
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                    con.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        // Clear Function
        public void Clear()
        {
            checkBarcode.Focus();
            checkBarcode.Clear();
            addItem.Clear();
            addRP.Clear();
            addSRP.Clear();
            addQty.Clear();
            addBrand.Text = "";
            addEXPD.Text = "";
        }

        // Submit Button
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkBarcode.Text == "" || addItem.Text == "" || addBrand.Text == "" || addQty.Text == "" || addSRP.Text == "" || addRP.Text == "" || addDOA.Text == "" || addEXPD.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                try
                {
                    con.Open();
                    string itemInsert = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodQty, prodSRP, prodRP, prodDOA, prodEXPD) VALUES (@pn, @pi, @pb, @py, @pp, @pq, @pdoa, @pexpd);";
                    con.query(itemInsert);

                    con.bind("@pn", checkBarcode.Text);
                    con.bind("@pi", addItem.Text);
                    con.bind("@pb", addBrand.Text);
                    con.bind("@py", addQty.Text);
                    con.bind("@pp", addSRP.Text);
                    con.bind("@pq", addRP.Text);

                    string str = addEXPD.Text;
                    DateTime dt = DateTime.Parse(str);

                    con.bind("@pdoa", DateTime.Now);
                    con.bind("@pexpd", dt);

                    con.cmd().Prepare();
                    int a = con.execute();
                    if (a == 1)
                    {
                        MessageBox.Show("Data added Sucessfully");
                        cbBrand();
                        checkBarcode.Focus();
                        Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Populate Brand Combobox
        public void cbBrand()
        {
            con.Close();
            try
            {
                con.Open();
                string query = "SELECT DISTINCT prodBrand FROM datainventory";
                con.query(query);
                con.execute();
                MySqlDataReader drd = con.read();

                while (drd.Read())
                {
                    addBrand.Items.Add(drd.GetString(0).ToString());
                }

                drd.Close();
                drd.Dispose();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        // Cancel Button
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            usc_inventory ui = new usc_inventory();
            usc_parent_overview upo = new usc_parent_overview();
            ui.mainSubColumn.Children.Add(upo);
        }
    }
}
