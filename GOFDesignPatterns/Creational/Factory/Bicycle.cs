using System;

namespace GOFDesignPatterns.Creational.Factory
{
    public class Bicycle : IVehicle
    {
        public void Actions()
        {
            Console.WriteLine("A Bicycle can go up and down the hill");
        }

        public void Parts()
        {
            Console.WriteLine("A Bicycle has two (2) Wheels");
        }
    }
}
