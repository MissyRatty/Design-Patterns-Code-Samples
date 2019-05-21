namespace GOFDesignPatterns.Structural.Proxy
{
    //This is the ISubject interface, which will be implemented by both the real object (Math) and the proxy class (MathProxy)
    public interface IMath
    {
        int Add(int num1, int num2);
        int Subtract(int num1, int num2);
        int Multiply(int num1, int num2);
        int Divide(int num1, int num2);
    }
}
