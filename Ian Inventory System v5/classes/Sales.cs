using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using NavigationDrawerPopUpMenu2.usercontrols;
using System.Windows.Forms;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Sales
    {
        public int refNo { get; set; }
        public long salesNo { get; set; }
        public string salesItem { get; set; }
        public string salesBrand { get; set; }
        public DateTime salesDate { get; set; }
        public int salesRP { get; set; }
        public int salesQty { get; set; }
        public int salesTotal { get; set; }

        Database conn = new Database();
        usc_sales usc = new usc_sales();
        



    }
}
