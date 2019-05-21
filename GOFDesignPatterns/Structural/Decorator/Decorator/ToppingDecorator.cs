namespace GOFDesignPatterns.Structural.Decorator
{
    //Decorator abstract class
    public abstract class ToppingDecorator : Pizza
    {
        //keeps object reference to Component Abstract Class (Pizza) through Composition
        //Decorator Concrete Classes will be able to reference this to get Cost and Description
        protected Pizza _pizza;

        public ToppingDecorator(Pizza newPizza)
        {
            _pizza = newPizza;
        }

        public override double GetCost()
        {
            return _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
