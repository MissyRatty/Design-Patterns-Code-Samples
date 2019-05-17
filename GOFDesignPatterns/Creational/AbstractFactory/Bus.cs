using System;

namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class Bus : Vehicle
    {
        public override void Actions()
        {
            Console.WriteLine("A Bus can go up and down the hill");
        }

        public override void Parts()
        {
            Console.WriteLine("A Bus can have more than four (4) Wheels");
        }
    }
}
