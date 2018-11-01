using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 1;

            for (int i = 1; i >= total; i++)
            {
                Console.WriteLine(i);
            }

            string name = "Joshua";

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            while (total != 5)
            {
                Console.WriteLine(total);
                total++;
            }

            Console.ReadLine();
        }
    }
}
