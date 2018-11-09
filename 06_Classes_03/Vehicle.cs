using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_03
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public Customer Owner { get; set; }


        public Vehicle(string make, string model, int modelYear, Customer owner)
        {
            Make = make;
            Model = model;
            ModelYear = modelYear;
            Owner = owner;
        }
        
        public Vehicle()
        {

        }
    }
}
