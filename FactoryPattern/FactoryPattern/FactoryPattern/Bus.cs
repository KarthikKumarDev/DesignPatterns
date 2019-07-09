namespace FactoryPattern
{
    public class Bus: IVehicle
    {
        public Bus()
        {
            _modelName = "Benz Bus";
        }
        public string _modelName { get; set; }

        public void DriveForward()
        {
            // Drive forward actions
        }
    }
}
