namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            _modelName = "Lamborghini";
        }

        public string _modelName { get; set; }

        public void DriveForward()
        {
            // Drive actions
        }
    }
}
