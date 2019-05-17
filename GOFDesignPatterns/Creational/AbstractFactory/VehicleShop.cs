namespace GOFDesignPatterns.Creational.AbstractFactory
{
    // this is the client code which requests for a vehicle object
    public class VehicleShop
    {
        private Vehicle _vehicle;

        public VehicleShop(VehicleFactory factory)
        {
            _vehicle = factory.CreateVehicle();
        }

        public void ConstructVehicle()
        {
            _vehicle.Actions();
            _vehicle.Parts();
        }
    }
}
