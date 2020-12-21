using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationDrawerPopUpMenu2.classes;
using System.Windows;
using NavigationDrawerPopUpMenu2.admin.admin_usercontrols;

namespace NavigationDrawerPopUpMenu2.classes
{
    class clientInfo
    {
        public long acc_number = 0;
        public string first_name = "";
        public string last_name = "";
        public string user_status = "";
        public string buss_name = "";
        public string buss_branch = "";
        public string buss_type = "";
        public string buss_town = "";
        public string buss_province = "";
        public string buss_country = "";
        public int buss_zipcode = 0;

        Database conn = new Database();

        public void registerClient()
        {
            string query = "INSERT INTO client_information (accNo, firstName, lastName, bussName, bussBranch, bussType, bussTown, bussProvince, bussCountry, bussZipcode, accCreated) VALUES (@no, @first, @last, @name, @branch, @type, @town, @province, @country, @zipcode, @date)";
            conn.query(query);
            try
            {
                conn.Open();
                conn.bind("@no", acc_number.ToString());
                conn.bind("@first", first_name);
                conn.bind("@last", last_name);
                conn.bind("@name", buss_name);
                conn.bind("@branch", buss_branch);
                conn.bind("@type", buss_type);
                conn.bind("@town", buss_town);
                conn.bind("@province", buss_province);
                conn.bind("@country", buss_country);
                conn.bind("@zipcode", buss_zipcode.ToString());
                conn.bind("@date", DateTime.Now);
                conn.cmd().Prepare();
                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("Data Added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void Clear()
        {
            acc_number = 0;
            first_name = "";
            last_name = "";
            buss_name = "";
            buss_branch = "";
            buss_type = "";
            buss_town = "";
            buss_province = "";
            buss_country = "";
            buss_zipcode = 0;
        }

    }
}
