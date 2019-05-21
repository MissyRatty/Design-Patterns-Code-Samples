using System;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    //This is a concrete colleague class
    public class Friend : FacebookUser
    {
        public Friend(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Receiving a message from a facebook user who is in your friend list => ");
            base.Receive(from, message);
        }
    }
}
