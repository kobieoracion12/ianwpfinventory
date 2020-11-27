using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationDrawerPopUpMenu2.usercontrols;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Checkout
    {
        UserControlCheckout usc = new UserControlCheckout();
        public int stocks = 0;
        public int subtotal = 0;
        public int vat = 0;
        public int total = 0;
        public int due = 0;
        public int paid = 0;
        public int tax = 0;
        public int bought = 0;
        public string payMethod = "";

        public void clearPartial()
        {
            usc.entrySearch.Clear();
            usc.coItem.Clear();
            usc.coBrand.Clear();
            usc.coSRP.Clear();
            usc.coRP.Clear();
        }

        public void clearAll()
        {

            usc.listViewinVoice.Items.Clear();
            usc.entrySearch.Clear();
            usc.coItem.Clear();
            usc.coBrand.Clear();
            usc.coSRP.Clear();
            usc.coRP.Clear();
            usc.coSubtotal.Clear();

            usc.pay_discount.Text = "0";
            usc.pay_subtotal.Text = "₱ 0.00";
            usc.pay_total.Text = "₱ 0.00";
            usc.pay_paid.Text = "₱ 0.00";
            usc.pay_due.Text = "₱ 0.00";

            subtotal = 0;
            vat = 0;
            total = 0;
            paid = 0;
            due = 0;
            usc.cashAmount.Text = "₱ 0.00";

            total = 0;

            usc.cashButton.IsEnabled = false;
            usc.voidEntry.IsEnabled = false;
        }
    }
}
