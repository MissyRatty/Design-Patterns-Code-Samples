using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Others.NullObjectPattern
{
    public interface IUser
    {
        string Name { get; }
        void IncrementSessionTicket();
    }
}
