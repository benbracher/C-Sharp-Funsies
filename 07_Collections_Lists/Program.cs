using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();
            List<Pet> listOfPets = new List<Pet>();

            Pet firstPet = new Pet("Ouch", 25, "???", false);
            Pet secondPet = new Pet("Rag", 69, "fish", false);
            Pet thirdPet = new Pet("Oingo Boingo", 15000, "demon spawn", true);

            listOfPets.Add(firstPet);
            listOfPets.Add(secondPet);
            listOfPets.Add(thirdPet);

            listOfPets.RemoveAt(4);
            listOfPets.Remove(firstPet);

            foreach (Pet pet in listOfPets)
            {
                Console.WriteLine(pet.Name);
            }

            Console.ReadLine();
        }
    }
}
