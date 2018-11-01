using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            int feeling = int.Parse(Console.ReadLine());

            switch (feeling)
            {
                case 1:
                    Console.WriteLine("Oh no");
                    break;
                case 2:
                    Console.WriteLine("Uh oh");
                    break;
                case 3:
                    Console.WriteLine("Oh man");
                    break;
                case 4:
                    Console.WriteLine("Oh boy");
                    break;
                case 5:
                    Console.WriteLine("Hell yeah");
                    break;

                default:
                    Console.WriteLine("Watch yourself!");
                    break;
            }

            //if (feeling == 1)
            //{
            //    Console.WriteLine("Oh no, that's terrible.");
            //}
            //else if (feeling == 2)
            //{
            //    Console.WriteLine("Uh oh");
            //}
            //else if (feeling == 3)
            //{
            //    Console.WriteLine("Oh man");
            //}
            //else if (feeling == 4)
            //{
            //    Console.WriteLine("Oh boy");
            //}
            //else if (feeling == 5)
            //{
            //    Console.WriteLine("Hell yeah");
            //}
            //else
            //{
            //    Console.WriteLine("Watch yourself");
            //}

            Console.ReadLine();
        }
    }
}
