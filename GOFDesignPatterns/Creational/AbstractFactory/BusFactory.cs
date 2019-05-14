namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class BusFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Bus();
        }
    }
}
