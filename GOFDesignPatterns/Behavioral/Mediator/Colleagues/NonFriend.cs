using System;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    //This is a concrete colleague class
    public class NonFriend : FacebookUser
    {
        public NonFriend(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Receiving a message from a facebook user who is not in your friend list => ");
            base.Receive(from, message);
        }
    }
}
