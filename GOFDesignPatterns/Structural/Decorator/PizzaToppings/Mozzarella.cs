using System;

namespace GOFDesignPatterns.Structural.Decorator
{

    //This is a concrete ToppingDecorator Decorator Class
    //since Mozzarella extends the ToppingDecorator Class,
    // it will have access to the IPizza object reference, and as such, have access to the methods on that object
    // i.e: ToppingDecorator.GetCost() and ToppingDecorator.GetDescription()
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza pizza)
            : base(pizza)
        {
            Console.WriteLine("Adding Mozzarella to your plain pizza");
        }

        public override double GetCost()
        {
            Console.WriteLine("Get Pizza With Mozzarella Cost");
            return _pizza.GetCost() + .50d;
        }

        public override string GetDescription()
        {
            Console.WriteLine("Get Pizza With Mozzarella Description");
            return _pizza.GetDescription() + ", Mozzarella";
        }

    }
}
