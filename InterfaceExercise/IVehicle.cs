using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int wheels { get; set; } 
        public int doors { get; set; }
        public double topSpeed { get; set; }

        public string engineType { get; set; }
    }
}
