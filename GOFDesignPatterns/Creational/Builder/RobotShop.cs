namespace GOFDesignPatterns.Creational.Builder
{
    public class RobotShop
    {
        // Builder uses a complex series of steps
        public void Construct(IRobotBuilder robotBuilder)
        {
            robotBuilder.BuildHead();
            robotBuilder.BuildArms();
            robotBuilder.BuildLegs();
        }
    }
}
