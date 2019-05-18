using System;

namespace GOFDesignPatterns.Structural.Decorator
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza newPizza)
            : base(newPizza)
        {
            Console.WriteLine("Adding Tomato Sauce to your plain pizza");
        }

        public override double GetCost()
        {
            Console.WriteLine("Get Pizza With Tomato Sauce Cost");
            return (_pizza.GetCost() + .20d);
        }

        public override string GetDescription()
        {
            Console.WriteLine("Get Pizza With Tomato Sauce Description");
            return (_pizza.GetDescription() + ", Tomato Sauce");
        }
    }
}
