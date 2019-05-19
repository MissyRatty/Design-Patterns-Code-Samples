namespace GOFDesignPatterns.Structural.Proxy
{
    //This is the Proxy Object Class. 
    //This will be used to control access to the real subject (Math)
    public class MathProxy : IMath
    {
        //an object reference to the real subject class (math)
        private readonly Math _math = new Math();

        public int Add(int num1, int num2)
        {
            return _math.Add(num1, num2);
        }

        public int Divide(int num1, int num2)
        {
            return _math.Divide(num1, num2);
        }

        public int Multiply(int num1, int num2)
        {
            return _math.Multiply(num1, num2);
        }

        public int Subtract(int num1, int num2)
        {
            return _math.Subtract(num1, num2);
        }
    }
}
