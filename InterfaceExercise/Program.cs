using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var newList = new List<IVehicle>();
            //Now, create objects of your 3 classes and give their members values;
            var car1 = new Car()
            {
                wheels = 4,
                doors = 2,
                topSpeed = 194.6,
                engineType = "w12",
                isManual = true,
                isSportsCar = true,
                logo = "Nates Lot",
                companyName = "Nates AutoTown"
            };
            var suv1 = new SUV()
            {
                wheels = 4,
                doors = 4,
                topSpeed = 100.4,
                engineType = "v6",
                cargoRoom = 12.6,
                numOfSeats = 8,
                logo = "Nates Lot",
                companyName = "Nates AutoTown"
            };
            var truck1 = new Truck()
            {
                wheels = 6,
                doors = 4,
                topSpeed = 125.2,
                engineType = "v8 deisel",
                hasBed = "Short Bed",
                has4x4 = false,
                logo = "Nates Lot",
                companyName = "Nates AutoTown"
            };
            //Creatively display and organize their values
            newList.Add(car1);
            newList.Add(suv1);
            newList.Add(truck1);

            var newList1 = new List<ICompany>();
            newList1.Add(car1);
            newList1.Add(suv1);
            newList1.Add(truck1);

            foreach (var item in newList)
            {
                Console.WriteLine($"Wheels: {item.wheels} Doors: {item.doors},Engine Type:  {item.engineType}, Top Speed: {item.topSpeed}");

            }
            foreach (var xy in newList1)
            {
                Console.WriteLine($"{xy.logo}\n{xy.companyName}");
            }
        }
    }
}
