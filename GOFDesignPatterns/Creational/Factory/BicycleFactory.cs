namespace GOFDesignPatterns.Creational.Factory
{
    //This subclass will create Bicycle objects
    public class BicycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            //create a bicycle
            return new Bicycle();
        }
    }
}
