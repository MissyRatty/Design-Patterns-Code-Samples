namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle();

        public Vehicle MakeVehicle()
        {
            Vehicle vehicle = CreateVehicle();
            vehicle.Actions();
            vehicle.Parts();

            return vehicle;
        }
    }
}
