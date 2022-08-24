using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car: IVehicle, ICompany
    {
        public bool isSportsCar { get; set; }
        public bool isManual { get; set; }
        public int wheels { get; set; }
        public int doors { get; set; }
        public double topSpeed { get; set; }

        public string engineType { get; set; }
        public string companyName { get; set; }
        public string logo { get; set; }
    }
}
