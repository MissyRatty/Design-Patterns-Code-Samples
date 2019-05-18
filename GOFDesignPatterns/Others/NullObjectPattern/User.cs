using System;

namespace GOFDesignPatterns.Others.NullObjectPattern
{
    public class User : IUser
    {
        public User(Guid newGuid)
        {
            UserId = newGuid;
            SessionTicketIncrement = 10;
        }

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public int SessionTicketIncrement { get; set; } 

        public void IncrementSessionTicket()
        {
            SessionTicketIncrement += 20; 
        }
    }
}
