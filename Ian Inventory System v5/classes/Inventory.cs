using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Inventory
    {
        public long prodId { get; set; }
        public long prodNo { get; set; }
        public string prodItem { get; set; }
        public string prodBrand { get; set; }
        public int prodQty { get; set; }
        public double prodSRP { get; set; }
        public double prodRP { get; set; }
        public double prodVAT { get; set; }
        public int prodBought { get; set; }
        public DateTime prodDOA { get; set; }
        public string prodCategory { get; set; }
    }
}
