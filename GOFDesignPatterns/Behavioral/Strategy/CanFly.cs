using System;

namespace GOFDesignPatterns.Behavioral.Strategy
{
    public class CanFly : IFly
    {
        public void Fly(string name)
        {
            Console.WriteLine(name + " is Flying high");
        }
    }
}
