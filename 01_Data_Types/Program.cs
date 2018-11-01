using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type  Name  = value
            //bool isTall = true;
            //int age = 25;

            //byte low = 0;
            //byte high = 255;

            //float floating = 123.4123f;
            //double number = 123.456d;
            //decimal number2 = 12345.12345m;

            ////Int16 == short
            ////Int64 == long
            //long number3 = 123;

            //char character = 'a';
            //string word = "This is a string";

            //Console.WriteLine("word");
            //Console.WriteLine(word);

            ////Console.ReadLine();
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //Console.ReadLine();

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName + ".");
            Console.WriteLine("I see you're " + age + " years old. You old fart. I shall send spam mail to: " + email + " forever more!");

            Console.ReadLine();
        }
    }
}
