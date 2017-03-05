using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module2_Assignment
{
    class Country
    {
        private string name;
        private int landmass;
        private List<string> states = new List<string>();
        private int population;
        private int GDP;
        private string president;

        public Country(string name, int landmass, int population, int GDP, string president)
        {
            this.name = name;
            this.landmass = landmass;
            this.population = population;
            this.GDP = GDP;
            this.president = president;
        }

        /// <summary>
        /// Adds a new state to a list of states in a country
        /// </summary>
        /// <param name="state"></param>
        public void AddState(string state)
        {
            states.Add(state);
        }

        /// <summary>
        /// Writes all info about the country to the console
        /// </summary>
        public void DisplayProfile()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("landmass: {0}sqft", landmass);

            Console.WriteLine("***********************************STATES************************************");
            if (states.Count == 0)
                Console.WriteLine("No State Available");
            else
            {
                foreach (var state in states)
                {
                    Console.WriteLine("*{0}", state);
                }
            }
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("population: {0}", population);
            Console.WriteLine("GDP: {0}", GDP);
        }

        /// <summary>
        /// Writes the number of states a country has to the console
        /// </summary>
        public void DisplayNumberOfStates()
        {
            Console.WriteLine("There are {0} states in {1}", states.Count, name);
            Console.Write("\n\n");
        }
    }
}
