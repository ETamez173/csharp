using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };
            // Console.WriteLine ("Hello World!");

            // Add() Jupiter and Saturn at the end of the list.

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            foreach (string planet in planetList) {
                Console.WriteLine (planet);
            }

            // Create another List that contains that last two planet of our solar system.
            List<string> planetList2 = new List<string> () { "Uranus", "Neptune" };

            foreach (string planet in planetList2) {
                Console.WriteLine (planet);
            }

            // Combine the two lists by using AddRange().

            Console.WriteLine ("\nAddRange(planetList)");
            planetList.AddRange (planetList);

            Console.WriteLine ();
            foreach (string planet in planetList) {
                Console.WriteLine (planet);
            }

            List<string> planetList3 = new List<string> () { "Mercury", "Mars" };
            // Use Insert() to add Earth 3, and Venus 2 in the correct order.

            // Insert a Venus at position 2.

            Console.WriteLine ("\nInsert(1, \"Venus 2nd planet\")");
            Console.WriteLine ("\nInsert(2, \"Earth 3rd planet\")");
            planetList3.Insert (1, "Venus");

            // Insert a Earth at position 3.
            // Console.WriteLine ("\nInsert(2, \"Earth\")");
            planetList3.Insert (2, "Earth");

            //Console.WriteLine();
            foreach (string planet in planetList3) {
                Console.WriteLine (planet);
            }

            // 1 Mercury, 2 Venus, 3 Earth, 4  Mars, 5 Jupiter,  6 Saturn, 
            //  7 Uranus, 8 Neptune, 9 Pluto

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add ("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine (planet);
            }

            // 1 Mercury, 2 Venus, 3 Earth, 4  Mars, 5 Jupiter,  6 Saturn, 
            //  7 Uranus, 8 Neptune, 9 Pluto

            List<string> planetList4 = new List<string> () { "Mercury", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            // Use Insert() to add Earth 3, and Venus 2 in the correct order.

            // Insert a Venus at position 2.

            Console.WriteLine ("\nInsert(1, \"Venus 2nd planet\")");
            Console.WriteLine ("\nInsert(2, \"Earth 3rd planet\")");
            planetList4.Insert (1, "Venus");
            planetList4.Insert (2, "Earth");

            // 1 Mercury, 2 Venus, 3 Earth, 4  Mars, 5 Jupiter,  6 Saturn, 
            //  7 Uranus, 8 Neptune, 9 Pluto

            // Use Add() again to add Pluto to the end of the list.
            planetList4.Add ("Pluto");

            foreach (string planet in planetList4) {
                Console.WriteLine (planet);
            }

            // 1 Mercury, 2 Venus, 3 Earth, 4  Mars, 5 Jupiter,  6 Saturn, 
            //  7 Uranus, 8 Neptune, 9 Pluto
            // The four rocky planets are Mercury index 0, Venus index 1, Earth index 2 and Mars index 3.

            Console.WriteLine ("\nrockyPlanets = planetList4.GetRange(0, 3).ToArray()");
            string[] rockyPlanets = planetList4.GetRange (0, 4).ToArray ();

            Console.WriteLine ();
            foreach (string planet in rockyPlanets) {
                Console.WriteLine (planet);
            }

            List<string> planetList5 = new List<string> () { "Mercury", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            // Use Insert() to add Earth 3, and Venus 2 in the correct order.

            // Insert a Venus at position 2.

            Console.WriteLine ("\nInsert(1, \"Venus 2nd planet\")");
            Console.WriteLine ("\nInsert(2, \"Earth 3rd planet\")");
            planetList5.Insert (1, "Venus");
            planetList5.Insert (2, "Earth");

            // 1 Mercury, 2 Venus, 3 Earth, 4  Mars, 5 Jupiter,  6 Saturn, 
            //  7 Uranus, 8 Neptune, 9 Pluto

            // Use Add() again to add Pluto to the end of the list.

            planetList5.Add ("Pluto");

            foreach (string planet in planetList5) {
                Console.WriteLine (planet);
            }

            //use the Remove() method to eliminate Pluto from the end of planetList.

            Console.WriteLine ("\nRemoveAt(8)");
            // This will remove the part at index 3.
            planetList5.RemoveAt (8);

            Console.WriteLine ();
            foreach (string planet in planetList5) {
                Console.WriteLine (planet);
            }

        }
    }
}