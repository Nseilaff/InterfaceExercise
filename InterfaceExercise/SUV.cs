using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public double cargoRoom { get; set; }
        public int numOfSeats { get; set; }
        public int wheels { get; set; }
        public int doors { get ; set ; }
        public double topSpeed { get ; set ; }
        public string engineType { get ; set; }
        public string companyName { get; set; }
        public string logo { get; set; }
    }
}
