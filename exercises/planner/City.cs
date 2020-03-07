using System;
using System.Collections.Generic;

namespace planner {

    public class City {
        // Name of the city.
        public string CityName { get; set; }
        //The mayor of the city.
        public string Mayor { get; set; }

        //Year the city was established.
        public int DateEstablished { get; set; }
        //A collection of all of the buildings in the city.

        //A method to add a building to the city.

        public City (string cityname, string mayor, int year) {
            CityName = cityname;
            Mayor = mayor;
            DateEstablished = year;

        }
        // Create List 
        public List<Building> Buildings = new List<Building> ();

        public void AddBuildingToCity (Building building) {

            Buildings.Add (building);
        }

    }

}