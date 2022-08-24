using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string hasBed { get; set; } 
        public bool has4x4 { get; set; }
        public int wheels { get; set; }
        public int doors { get; set; }
        public double topSpeed { get; set; }

        public string engineType { get; set; }
        public string companyName { get; set; }
        public string logo { get; set; }
    }
}

