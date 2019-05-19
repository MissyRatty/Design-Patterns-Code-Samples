namespace GOFDesignPatterns.Behavioral.Strategy
{
    public interface IAnimal
    {
        //an instance property that can be any subclass of the IFly interface
        IFly FlyingType { get; set; }
        void MakeSound();
        void TryToFly();
        void SetFlyingAbility(IFly newFlyType);
    }
}
