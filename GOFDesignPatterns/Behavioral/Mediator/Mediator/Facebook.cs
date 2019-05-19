namespace GOFDesignPatterns.Behavioral.Mediator
{
    //This is the mediator abstract class
    public abstract class Facebook
    {
        public abstract void Register(FacebookUser user);
        public abstract void Send(string from, string to, string message);
    }
}
