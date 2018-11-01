using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsChallengeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            string name = "";
            int age = 0;
            string year = "";
            int yearAge = 0;
            int carMileage = 0;
            int mileageDivide = 0;
            string accident = "";
            decimal charge = 0m;

            while (response != "close")
            {
                Console.WriteLine("Komodo Auto Insurance Age Check:");
                Console.WriteLine("");

                Console.WriteLine("Choose a selection:");
                Console.WriteLine("'register' your vehicle");
                Console.WriteLine("View your 'profile'");
                Console.WriteLine("'update' your profile");
                Console.WriteLine("'close' the App");
                Console.WriteLine("");
                response = Console.ReadLine();
                Console.Clear();

                do
                {
                    switch (response)
                    {
                        case "register":
                        case "update":
                            name = "";
                            age = 0;
                            year = "";
                            yearAge = 0;
                            carMileage = 0;
                            mileageDivide = 0;
                            accident = "";
                            charge = 0m;

                            Console.WriteLine("Please enter your full name:");
                            name = Console.ReadLine();
                            Console.WriteLine("Please enter your age:");
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the year your vehicle was manufactured:");
                            year = Console.ReadLine();
                            yearAge = 2018 - int.Parse(year);
                            Console.WriteLine("How many miles are on your vehicle:");
                            carMileage = int.Parse(Console.ReadLine());
                            mileageDivide = carMileage / 50000;
                            Console.WriteLine("Have you been involved in any accidents (Y/N)?");
                            accident = Console.ReadLine();

                            if (age >= 25)
                                charge += 75m;
                            else
                                charge += 125m;

                            if (yearAge < 5)
                                charge += 75m;
                            else if (yearAge > 15)
                                charge += 150m;
                            else
                                charge += 100m;

                            if (accident == "Y")
                                charge += 25m;

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

                            Console.WriteLine("'return' to menu");
                            response = Console.ReadLine();
                            Console.Clear();
                            break;
                        case "profile":
                            Console.WriteLine($"Profile for {name}:");
                            Console.WriteLine($"Age: {age}");
                            Console.WriteLine($"Vehicle Year: {year}");
                            Console.WriteLine($"Vehicle Mileage: {carMileage}");
                            Console.WriteLine($"Accidents(Y/N): {accident}");
                            Console.WriteLine($"Insurance Premium: {charge}");
                            Console.WriteLine("'return' to menu");
                            response = Console.ReadLine();
                            Console.Clear();
                            break;
                        case "close":
                            break;
                    }
                    if (response == "close")
                        break;
                } while (response != "return");
            }
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}