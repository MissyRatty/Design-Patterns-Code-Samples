using System;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    //This is the Abstract Colleague Class
    public class FacebookUser
    {
        public FacebookUser(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Facebook Chatroom { set; get; }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
