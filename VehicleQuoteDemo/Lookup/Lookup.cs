using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;

namespace VehicleQuoteDemo.Lookup
{
    public class Lookup : ILookup
    {
        public List<State> GetListOfStates()
        {
            List<State> stateList = new List<State>();
            //Create State Object
            State newyork = new State();
            newyork.Code = "NY";
            newyork.Name = "New York";

            //Add the New York State to the list

            stateList.Add(newyork);

            State newJersy = new State();
            newJersy.Code = "NJ";
            newJersy.Name = "New Jersey";

            stateList.Add(newJersy);

            stateList.Add(new State() { Code = "CA", Name = "California" });
            return stateList;
        }


        public List<int> GetListOfYears()
        {
           List<int> yearsList = new List<int>();

            for (int year=1980; year< 2015; year++)
            {
                 yearsList.Add(year);
            }

            return yearsList;
        }


        public List<Vehicle> GetVehicleMakesList(string year)
        {
            var vehiclesList = GetAllVehicles();

            List<Vehicle> filteredVehicles = new List<Vehicle>();
            foreach (var vehicle in vehiclesList)
            {
                if(vehicle.Year==year)
                    filteredVehicles.Add(vehicle);
            }

            //for (int i = 0; i < vehiclesList.Count; i++)
            //{
            //    if (vehiclesList[i].Year == year)
            //    {
            //        filteredVehicles.Add(vehiclesList[i]);
            //    }
            //}

            return filteredVehicles;
            //     var vehecileMakesList=  vehiclesList.Where(vehicle => vehicle.Year == year);
            // return vehecileMakesList.ToList();
        }

        private List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle() { Year = "2015", Make = "Audi", Model = "A5" });
            vehicles.Add(new Vehicle() { Year = "2014", Make = "Benz", Model = "C200" });
            vehicles.Add(new Vehicle() { Year = "2014", Make = "Audi", Model = "A5" });
            vehicles.Add(new Vehicle() { Year = "2013", Make = "Ford", Model = "icon" });
            vehicles.Add(new Vehicle() { Year = "2012", Make = "Ford", Model = "Fiesta" });
            vehicles.Add(new Vehicle() { Year = "2013", Make = "Nissan", Model = "Ultima" });
            vehicles.Add(new Vehicle() { Year = "2014", Make = "Nissan", Model = "Terrano" });
            vehicles.Add(new Vehicle() { Year = "2012", Make = "Hyundai", Model = "Sonata" });
            vehicles.Add(new Vehicle() { Year = "2013", Make = "Honda", Model = "Accord" });
            vehicles.Add(new Vehicle() { Year = "2014", Make = "Jaguar", Model = "NewJaguar" });

            return vehicles;
        }
    }
}