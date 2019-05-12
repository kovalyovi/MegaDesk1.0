using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        public string CustomerName;
        public string ShippingType;
        public decimal QuotePrice;
        public Desk Desk;
        public DateTime Date;

        public double GetQuote()
        {
            return 0.0;
        }
    }
}
