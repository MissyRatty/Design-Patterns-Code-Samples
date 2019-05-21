namespace GOFDesignPatterns.Structural.Proxy
{
    //This is the Real Subject that we want to control access to.
    public class Math : IMath
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
