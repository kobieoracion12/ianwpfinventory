using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Settings
    {
        Database conn = new Database();

        // USER SETTINGS HERE //
        public string user, pass, language, strId, strName, strAddress, stTIN, stSerial, stMIN;

        public string catchData = "SELECT * FROM store";

        public string catchUser = "SELECT acc_no, usersName FROM usersinventory";

        public string saveInfo = "UPDATE store SET store_name = @name, store_address = @address, store_tin = @tin, store_serial_number = @serial, store_min = @min WHERE store_id = @id ";



        // POS SETTINGS STARTS HERE //
        public string posUserId, posUser, posNewPass, posCurPass;

        public string savePosInfo = "UPDATE usersinventory SET usersName = @name, usersPass = @pass WHERE acc_no = @no";
    }
}
