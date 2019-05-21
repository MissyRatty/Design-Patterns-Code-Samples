using System;

namespace GOFDesignPatterns.Structural.Decorator
{
    //Concrete Component Class
    public class PlainPizza : Pizza
    {
        public override double GetCost()
        {
            Console.WriteLine("Every Plain Pizza costs 5.0");
            return 5.0d;
        }

        public override string GetDescription()
        {
            Console.WriteLine("Every Plain Pizza has Thin Dough");
            return "Thin Dough";
        }
    }
}
