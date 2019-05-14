namespace GOFDesignPatterns.Creational.Factory
{
    //an interface that creates vehicle objects but lets its subclass decide what type of vehicle object to create
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
