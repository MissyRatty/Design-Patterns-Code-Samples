using System;

namespace GOFDesignPatterns.Creational.Factory
{
    public class Car : IVehicle
    {
        public void Actions()
        {
            Console.WriteLine("A Car can go up and down the hill");
        }

        public void Parts()
        {
            Console.WriteLine("A Car has four (4) Wheels");
        }
    }
}
