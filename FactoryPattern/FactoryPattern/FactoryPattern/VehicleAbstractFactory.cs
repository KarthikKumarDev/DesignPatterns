namespace FactoryPattern
{
    public static class VehicleAbstractFactory
    {
        public static IVehicle CreateVehicle(string type)
        {
            if (type == "car")
            {
                return new Car();
            }
            else
            {
                return new Bus();
            }
        }
    }
}
