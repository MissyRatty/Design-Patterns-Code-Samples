namespace GOFDesignPatterns.Creational.Builder
{
    //Defines Common Attributes and Actions of All Robots
    public interface IRobotBuilder
    {
        void BuildHead();
        void BuildArms();
        void BuildLegs();
        Robot GetRobot();
    }
}
