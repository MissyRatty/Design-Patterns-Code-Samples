using System;

namespace GOFDesignPatterns.Behavioral.Strategy
{
    public class CannotFly : IFly
    {
        public void Fly(string name)
        {
            Console.WriteLine(name + " says I can't fly");
        }
    }
}
