using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Store
    {
        private string store_Name;
        private string store_Address;
        private string store_Tin;
        private string store_SerialNo;
        private string store_Min;

        public String storeName(Database conn)
        { 
            try
            {
                string query = "SELECT store_name FROM store";
                conn.query(query);
                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    this.store_Name = reader["store_name"].ToString();
                }

                conn.Close();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Store Info Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return this.store_Name;
        }

        public String storeAddress(Database conn)
        {
            try
            {
                string query = "SELECT store_address FROM store";
                conn.query(query);
                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    this.store_Address = reader["store_address"].ToString();
                }

                conn.Close();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Store Info Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return this.store_Address;
        }

        public String storeTin(Database conn)
        {
            try
            {
                string query = "SELECT store_tin FROM store";
                conn.query(query);
                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    this.store_Tin = reader["store_tin"].ToString();
                }

                conn.Close();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message + ", Try again later", "Store Info Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return this.store_Tin;
        }

        public String storeSN(Database conn)
        {
            try
            {
                string query = "SELECT store_serial_number FROM store";
                conn.query(query);
                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    this.store_SerialNo = reader["store_serial_number"].ToString();
                }

                conn.Close();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", Try again later", "Store Info Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return this.store_SerialNo;
        }

        public String storeMin(Database conn)
        {
            try
            {
                string query = "SELECT store_min FROM store";
                conn.query(query);
                conn.Open();
                MySqlDataReader reader = conn.read();
                if (reader.Read())
                {
                    this.store_Min = reader["store_min"].ToString();
                }

                conn.Close();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", Try again later", "Store Info Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return this.store_Min;
        }
    }
}
