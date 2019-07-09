using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)

        {
            // Centralize the Car object creation at the factory and decouple it from Client
            var myCar = VehicleFactory.CreateCar();
            Console.WriteLine("CreateCar: " + myCar._modelName );

            // Use abstractions to create Vehicles
            var myVehicle = VehicleAbstractFactory.CreateVehicle("myVehicle");
            Console.WriteLine("CreateVehicle: " + myVehicle._modelName);
            Console.ReadKey();
        }
    }
}
