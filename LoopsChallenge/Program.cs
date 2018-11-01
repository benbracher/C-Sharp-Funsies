using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal charge;

            Console.WriteLine("Komodo Auto Insurance Age Check:");
            Console.WriteLine("");

            Console.WriteLine("Please enter your name to begin: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the age of your vehicle?");
            string carAge = Console.ReadLine();
            string carAge2 = carAge.Substring(0, 2);
            int actualCarAge = int.Parse(carAge2);

            Console.WriteLine("Update your car's mileage? (Y/N)?");
            string response = Console.ReadLine().ToLower();

            while (response == "y")
            {
                Console.WriteLine("How many miles are on your vehicle?");
                string carMileage = Console.ReadLine();
                int actualCarMileage = int.Parse(carMileage);
                int mileageDivide = actualCarMileage / 50000;

                if (actualCarAge < 5)
                {
                    charge = 75m;
                }
                else if (actualCarAge > 15)
                {
                    charge = 150m;
                }
                else
                {
                    charge = 100m;
                }
                switch (mileageDivide)
                {
                    case 1:
                        charge += 25m;
                        break;
                    case 2:
                        charge += 50m;
                        break;
                    case 3:
                        charge += 75m;
                        break;
                    case 4:
                        charge += 100m;
                        break;
                    default:
                        charge += 125m;
                        break;
                }
                Console.WriteLine("Hello, Mr./Mrs. " + name + ". Your insurance premium is $" + charge + ".");
                Console.WriteLine("Update your car's mileage? (Y/N)?");
                response = Console.ReadLine().ToLower();
            }

            if (response == "n")
            {
                Console.WriteLine("Have a great day!");
            }
        }
    }
}
