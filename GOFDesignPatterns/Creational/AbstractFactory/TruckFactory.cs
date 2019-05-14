namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class TruckFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
