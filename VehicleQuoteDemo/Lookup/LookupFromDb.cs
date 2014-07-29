using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleQuoteDemo.Lookup
{
    public class LookupFromDataBase :ILookup
    {
        public List<State> GetListOfStates()
        {
            throw new NotImplementedException();
        }

        public string XYZ()
        {
            return "xyz";
        }


        public List<int> GetListOfYears()
        {
            throw new NotImplementedException();
        }
    }
}