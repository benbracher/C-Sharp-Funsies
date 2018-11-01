using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How old are you?");
            //string ageAsString = Console.ReadLine();
            //int actualAge = int.Parse(ageAsString);

            //if (actualAge < 18)
            //{
            //    Console.WriteLine("Hey there kid.");
            //}
            //else
            //{
            //    Console.WriteLine("Hello peer.");
            //}

            //// == Equal to
            //if (actualAge == 18)
            //{
            //    Console.WriteLine("Is 18");
            //}
            //// != Not equal to
            //if (actualAge != 18)
            //{
            //    Console.WriteLine("Not 18");
            //}
            //// && And
            //if (actualAge > 18 && actualAge < 65)
            //{
            //    Console.WriteLine("And condition");
            //}
            //// || Or
            //if (actualAge < 18 || actualAge > 25)
            //{
            //    Console.WriteLine("Or condition");
            //}

            //Write a series of conditionals to check the age of a car for an
            //insurance company that checks for the following conditions:
            //Car age older than 15
            //Car age between 5 and 15 and
            //Car age less than 5.
            //Komodo would like to charge three different premiums based on
            //the car's age with the oldest at $150, middle at $100, and
            //the youngest at $75.
            //Bonus: Komodo would also like to raise the premium if the car's
            //mileage is greater than 50,000 miles by $25.
            //They would also like to print a message greeting the customer by
            //name and telling them their premium.

            decimal charge;

            Console.WriteLine("Komodo Auto Insurance Age Check:");
            Console.WriteLine("");

            Console.WriteLine("Please enter your name to begin: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the age of your vehicle?");
            string carAge = Console.ReadLine();
            string carAge2 = carAge.Substring(0, 2);
            int actualCarAge = int.Parse(carAge2);

            Console.WriteLine("How many miles are on your vehicle?");
            int carMileage = int.Parse(Console.ReadLine());
            int mileageDivide = carMileage / 50000;

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
                case 5:
                    charge += 125m;
                    break;
                case 6:
                    charge += 150m;
                    break;
                case 7:
                    charge += 175m;
                    break;
                case 8:
                    charge += 200m;
                    break;
                case 9:
                    charge += 225m;
                    break;
                case 10:
                    charge += 250m;
                    break;
            }

            Console.WriteLine("Hello, Mr./Mrs. " + name + ". Your insurance premium is $" + charge + ".");
            Console.ReadLine();
        }
    }
}
