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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_settings : UserControl
    {
        Database conn = new Database();
        Settings setting = new Settings();

        public usc_settings()
        {
            InitializeComponent();
            catchData();
            catchUser();
        }

        // Fetch Store Details
        public void catchData()
        {
            string sql = setting.catchData;
            conn.query(sql);

            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                    storeId.Text = row[0];
                    storeName.Text = row[1];
                    storeAddress.Text = row[2];
                    storeTIN.Text = row[3];
                    storeSerial.Text = row[4];
                    storeMIN.Text = row[5];
                }

                reader.Close();
                reader.Dispose();
                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fetch User Information
        public void catchUser()
        {
            string sql = setting.catchUser;
            conn.query(sql);

            try
            {
                conn.Open(); // Open Connection
                MySqlDataReader reader = conn.read(); // Execute

                // Append the data to be edited in the textbox
                if (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1) };
                    userId.Text = row[0];
                    settingUser.Text = row[1];
                }

                reader.Close();
                reader.Dispose();
                conn.Close(); // Close Connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Save Store Details
        public void saveStoreDetails()
        {
            setting.strId = storeId.Text;
            setting.strName = storeName.Text;
            setting.strAddress = storeAddress.Text;
            setting.stTIN = storeTIN.Text;
            setting.stSerial = storeSerial.Text;
            setting.stMIN = storeMIN.Text;

            string sql = setting.saveInfo;
            conn.query(sql);
            conn.Close();
            try
            {
                conn.Open();
                conn.bind("@id", setting.strId);
                conn.bind("@name", setting.strName);
                conn.bind("@address", setting.strAddress);
                conn.bind("@tin", setting.stTIN);
                conn.bind("@serial", setting.stSerial);
                conn.bind("@min", setting.stMIN);

                conn.cmd().Prepare();
                conn.execute();

                MessageBox.Show("Successfully Updated");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Save Button
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            saveStoreDetails();
        }
    }
}
