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
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.windows
{
    /// <summary>
    /// Interaction logic for win_changequantity_stockout.xaml
    /// </summary>
    public partial class win_changequantity_stockout : Window
    {
        Database conn = new Database();
        usc_stockout usc_stockout;
        string prodQty = "";
        string transNo = "";
        public win_changequantity_stockout(usc_stockout usc_stockout, string trans)
        {
            InitializeComponent();
            this.usc_stockout = usc_stockout;
            transNo = trans;
        }

        private void txtQtyChange_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    conn.Open();
                    string queryQty = "SELECT prodQty FROM datainventory WHERE prodItem = @salesItem";
                    conn.query(queryQty);
                    conn.bind("@salesItem", usc_stockout.tbPrdName.Text);
                    conn.cmd().Prepare();
                    MySqlDataReader dr = conn.read();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            prodQty = dr["prodQty"].ToString();
                        }
                    }

                    dr.Close();
                    dr.Dispose();
                    conn.Close();

                        /* SALES QUANTITY
                       * SET A NEW TOTAL QUANTITY
                       */
                        conn.Open();
                        string query = "UPDATE stock_in SET stockinQty = @salesQty WHERE stockinRefNo = @salesTransNo AND stockinItem = @salesItem";
                        conn.query(query);
                        conn.bind("@salesQty", txtQtyChange.Text.Trim());
                        conn.bind("@salesTransNo", transNo);
                        conn.bind("@salesItem", usc_stockout.tbPrdName.Text);
                        conn.cmd().Prepare();
                        conn.execute();
                        conn.Close();

                        conn.Open();
                        usc_stockout.loadDatas(); // Update UI
                        conn.Close();
                        this.Close();

                    
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message + ", Try again later", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Validate
        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var txtQtyChange = sender as TextBox;
            // Use SelectionStart property to find the caret position.
            // Insert the previewed text into the existing text in the textbox.
            var fullText = txtQtyChange.Text.Insert(txtQtyChange.SelectionStart, e.Text);

            double val;
            // If parsing is successful, set Handled to false
            e.Handled = !double.TryParse(fullText, out val);
        }
    }
}
