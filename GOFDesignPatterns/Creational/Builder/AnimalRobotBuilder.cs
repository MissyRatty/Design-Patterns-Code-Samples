namespace GOFDesignPatterns.Creational.Builder
{
    public class AnimalRobotBuilder : IRobotBuilder
    {
        private Robot _robot = new Robot();

        public void BuildArms()
        {
            _robot.Add("Sorry, animal robots do not have arms");
        }

        public void BuildHead()
        {
            _robot.Add("Adding animal robot head");
        }

        public void BuildLegs()
        {
            _robot.Add("Adding animal robot legs");
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
