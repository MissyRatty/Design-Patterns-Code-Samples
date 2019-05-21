using System;

namespace GOFDesignPatterns.Behavioral.Strategy
{
    public class Dog : IAnimal
    {
        //done with composition
        //this will allow us to change the capability of objects at runtime
        public IFly FlyingType { get; set; } = new CannotFly();

        public void MakeSound()
        {
            Console.WriteLine("A Dog Barks");
        }

        public void SetFlyingAbility(IFly newFlyType)
        {
            FlyingType = newFlyType;
        }

        public void TryToFly()
        {
            FlyingType.Fly(nameof(Dog));
        }
    }
}
