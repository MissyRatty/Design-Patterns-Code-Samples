namespace GOFDesignPatterns.Creational.Builder
{
    public class HumanRobotBuilder : IRobotBuilder
    {
        private Robot _robot = new Robot();

        public void BuildArms()
        {
            _robot.Add("Adding 2 human robot arms");
        }

        public void BuildHead()
        {
            _robot.Add("Adding human robot head");
        }

        public void BuildLegs()
        {
            _robot.Add("Adding 2 human robot legs");
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
