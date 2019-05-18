using System;

namespace GOFDesignPatterns.Others.NullObjectPattern
{
    public interface IUserRepository
    {
        IUser GetUserById(Guid Id);
    }
}
