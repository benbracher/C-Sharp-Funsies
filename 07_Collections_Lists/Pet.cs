using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Pet
    {
        public string Name { get; set; }
        public int LegCount { get; set; }
        public string Breed { get; set; }
        public bool IsClean { get; set; }

        public Pet(string name, int legs, string breed, bool clean)
        {
            Name = name;
            LegCount = legs;
            Breed = breed;
            IsClean = clean;
        }
    }
}
