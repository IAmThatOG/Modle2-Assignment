using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Nigeria = new Country("Nigeria", 500000, 60000000, 5, "Buhari");
            Nigeria.AddState("Lagos");
            Nigeria.AddState("Kaduna");
            Nigeria.DisplayProfile();
            Nigeria.DisplayNumberOfStates();

            Country USA = new Country("The United States Of America", 1000000, 50000000, 30, "Donald Trump");
            USA.AddState("Kentucky");
            USA.DisplayProfile();
            USA.DisplayNumberOfStates();

            Console.ReadKey();
        }
    }
}
