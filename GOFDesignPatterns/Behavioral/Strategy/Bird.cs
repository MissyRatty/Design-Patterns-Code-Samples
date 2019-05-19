using System;

namespace GOFDesignPatterns.Behavioral.Strategy
{
    public class Bird : IAnimal
    {
        //done with composition
        //this will allow us to change the capability of objects at runtime
        public IFly FlyingType { get; set; } = new CanFly();

        public void MakeSound()
        {
            Console.WriteLine("A Bird Tweets");
        }

        public void SetFlyingAbility(IFly newFlyType)
        {
            FlyingType = newFlyType;
        }

        public void TryToFly()
        {
            FlyingType.Fly(nameof(Bird));
        }
    }
}
