namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static Car CreateCar()
        {
            return new Car();
        }

    }
}
