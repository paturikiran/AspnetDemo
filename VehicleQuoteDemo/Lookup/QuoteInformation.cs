using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleQuoteDemo.Lookup
{
    public class QuoteInformation
    {
        public Person InsurerDetails { get; set; }

        public Vehicle VehicleInformation { get; set; }

        public string Quotation { get; set; }
    }
}