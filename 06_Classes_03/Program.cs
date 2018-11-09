using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_03
{
    class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static Customer newCustomer;
        static Vehicle newVehicle;
        static bool menu = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Insurance\n");
            RegisterCustomer();
            RegisterVehicle(newVehicle);

            while (menu == true)
            {

                Console.Clear();
                Console.WriteLine("Please choose one of the following:\n");
                Console.WriteLine("\t1.View Profile Info");
                Console.WriteLine("\t2.Update Profile Info");
                Console.WriteLine("\t3.Add New Vehicle to Profile");
                Console.WriteLine("\t4.Close");
                int response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        Profile();
                        break;
                    case 2:
                        RegisterCustomer();
                        RegisterVehicle(newVehicle);
                        break;
                    case 3:
                        AddNewVehicle(newVehicle);
                        break;
                    default:
                        menu = false;
                        break;
                }
            }
        }

        public static void RegisterCustomer()
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string nameLast = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your address:");
            string address = Console.ReadLine();

            newCustomer = new Customer(name, nameLast, age, address);
            Console.Clear();
        }

        public static Vehicle ReceiveUserInfo()
        {
            Console.WriteLine("Please enter your vehicle's make:");
            string make = Console.ReadLine();
            Console.WriteLine("Please enter your vehicle's model:");
            string model = Console.ReadLine();
            Console.WriteLine("Please enter your vehicle's model year:");
            int modelYear = int.Parse(Console.ReadLine());

            Vehicle newVehicle = new Vehicle() { Make = make, Model = model, ModelYear = modelYear };
            return newVehicle;
        }

        public static void RegisterVehicle(Vehicle newVehicle)
        {

            var vehicle = ReceiveUserInfo();
            vehicles.Clear();
            vehicles.Add(vehicle);
            Console.WriteLine("Press any key to return to menu...");
            menu = true;
            Console.ReadLine();
            Console.Clear();
        }

        public static void AddNewVehicle(Vehicle newVehicle)
        {
            var vehicle = ReceiveUserInfo();
            vehicles.Add(vehicle);
            Console.WriteLine("Press any key to return to menu...");
            menu = true;
            Console.ReadLine();
            Console.Clear();
        }

        public static void Profile()
        {
            Console.WriteLine($"Profile for {newCustomer.FirstName} {newCustomer.LastName}:");
            Console.WriteLine($"\tAge: {newCustomer.Age}");
            Console.WriteLine($"\tAddress: {newCustomer.Address}");
            foreach(Vehicle aVehicle in vehicles)
            {
                Console.WriteLine($"\tVehicle(s):{aVehicle.ModelYear} {aVehicle.Make} {aVehicle.Model}");
            }
            Console.WriteLine("Press any key to return to menu...");
            menu = true;
            Console.ReadLine();
        }

        //static Vehicle newVehicle;
        //static Vehicle newVehicle2;
        //static Customer newCustomer;
        //static bool menu = true;

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to Komodo Insurance\n\n");
        //    RegisterPerson();
        //    RegisterVehicle();

        //    while (menu == true)
        //    {

        //        Console.Clear();
        //        Console.WriteLine("Please choose one of the following:\n");
        //        Console.WriteLine("\t1.View Profile Info");
        //        Console.WriteLine("\t2.Update Profile Info");
        //        Console.WriteLine("\t2.Add New Vehicle to Profile");
        //        Console.WriteLine("\t4.Close");
        //        int response = int.Parse(Console.ReadLine());

        //        switch (response)
        //        {
        //            case 1:
        //                Profile();
        //                break;
        //            case 2:
        //                RegisterPerson();
        //                RegisterVehicle();
        //                break;
        //            case 3:
        //                AddVehicle();
        //                break;
        //            default:
        //                menu = false;
        //                break;
        //        }
        //    }

        //}

        //public static void RegisterPerson()
        //{
        //    Console.WriteLine("Please enter your first name:");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Please enter your last name:");
        //    string nameLast = Console.ReadLine();
        //    Console.WriteLine("Please enter your age:");
        //    int age = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter your address:");
        //    string address = Console.ReadLine();

        //    newCustomer = new Customer(name, nameLast, age, address);
        //    Console.Clear();
        //}

        //public static void RegisterVehicle()
        //{
        //    Console.WriteLine("Please enter your vehicle's make:");
        //    string make = Console.ReadLine();
        //    Console.WriteLine("Please enter your vehicle's model:");
        //    string model = Console.ReadLine();
        //    Console.WriteLine("Please enter your vehicle's model year:");
        //    int modelYear = int.Parse(Console.ReadLine());

        //    newVehicle = new Vehicle(make, model, modelYear, newCustomer);
        //    Console.WriteLine("Press any key to return to menu...");
        //    menu = true;
        //    Console.ReadLine();
        //    Console.Clear();
        //}

        //public static void AddVehicle()
        //{
        //    Console.WriteLine("Please enter your vehicle's make:");
        //    string make = Console.ReadLine();
        //    Console.WriteLine("Please enter your vehicle's model:");
        //    string model = Console.ReadLine();
        //    Console.WriteLine("Please enter your vehicle's model year:");
        //    int modelYear = int.Parse(Console.ReadLine());

        //    newVehicle2 = new Vehicle(make, model, modelYear, newCustomer);
        //    Console.WriteLine("Press any key to return to menu...");
        //    menu = true;
        //    Console.ReadLine();
        //    Console.Clear();
        //}

        //public static void Profile()
        //{
        //    Console.WriteLine($"Name: {newCustomer.FirstName} {newCustomer.LastName}");
        //    Console.WriteLine($"Age: {newCustomer.Age}");
        //    Console.WriteLine($"Address: {newCustomer.Address}");
        //    Console.WriteLine($"Vehicle(s): {newVehicle.ModelYear} {newVehicle.Make} {newVehicle.Model}\n {newVehicle2.ModelYear} {newVehicle2.Make} {newVehicle2.Model}");
        //    Console.WriteLine("Press any key to return to menu...");
        //    menu = true;
        //    Console.ReadLine();
        //}
    }
}
