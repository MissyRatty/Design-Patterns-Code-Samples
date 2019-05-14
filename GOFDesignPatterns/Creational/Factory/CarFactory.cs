namespace GOFDesignPatterns.Creational.Factory
{
    //This subclass will create Car objects
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            //create a car
            return new Car();
        }
    }
}
