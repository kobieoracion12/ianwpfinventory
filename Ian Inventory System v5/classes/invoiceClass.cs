using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationDrawerPopUpMenu2.usercontrols;
using NavigationDrawerPopUpMenu2.windows;

namespace NavigationDrawerPopUpMenu2.classes
{
    class invoiceClass
    {
        
        window_cashButton wcb = new window_cashButton();

        public string cash
        {
            get { return wcb.cashAmount.Text; }
        }


        public class gg
        {
            public string salesNo { get; set; }

            public string salesItem { get; set; }

            public string salesRP { get; set; }

            public string salesQty { get; set; }

            public string salesTotal { get; set; }

            public DateTime salesDate { get; set; }
        }
    }
}
