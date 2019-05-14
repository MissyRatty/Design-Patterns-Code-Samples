using System;

namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class Truck : Vehicle
    {
        public override void Actions()
        {
            Console.WriteLine("A Truck can go up and down the hill");
        }

        public override void Parts()
        {
            Console.WriteLine("A Truck can have more than (4) Wheels");
        }
    }
}
