using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum Shipping
    {
        NoRush,
        Rush3Day,
        Rush5Day,
        Rush7Day
    }
    class DeskQuote
    {
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        public string Shipping { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            //temporary
            return 0;
        }
    }
}
