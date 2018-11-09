using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_List_Example
{
    class Program
    {
        static Person firstPerson = new Person();

        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            firstPerson.FullName = Console.ReadLine();

            Console.WriteLine("Do you have a car? (y/n)");
            string input = Console.ReadLine();

            bool addingCars = true;

            while (addingCars == true)
            {
                Console.WriteLine("Do you want to add another car?");
                input = Console.ReadLine();
            }

        }

        static void CheckAnswer(string input)
        {
            switch (input)
            {
                case "y":
                    RegisterCar();
                    break;
                case "n":
                    addingCars = false;
                    break;
            }
        }

        static void RegisterCar()
        {
            Car newCar = new Car();
            Console.WriteLine("What is the make of your car?");
            newCar.CarMake = Console.ReadLine();

            Console.WriteLine("What is the model of your car?");
            newCar.CarModel = Console.ReadLine();

            firstPerson.CarList.Add(newCar);
        }
    }
}
