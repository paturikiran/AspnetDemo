using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleQuoteDemo.Lookup
{
    public interface ILookup
    {
        List<State> GetListOfStates();

        List<int> GetListOfYears();

        List<Vehicle> GetVehicleMakesList(string year);
    }
}
//Year =2015, Make="Audi" Model="A5"
//Year =2014, Make="Benz" Model="C200"
//Year =2012, Make="Ford" Model="Icon"
//Year =1990, Make="Audi" Model="A5"
//Year =2013, Make="Audi" Model="A5"
//Year =2015, Make="Benz" Model="A5"
//Year =2015, Make="Renault" Model="Duster"
//Year =2015, Make="Nissan" Model="Terrano"


