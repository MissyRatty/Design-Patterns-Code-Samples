using System;
using System.Collections.Generic;
using System.Linq;

namespace GOFDesignPatterns.Others.NullObjectPattern
{
    public class UserRepository : IUserRepository
    {
        //some in-memory data
        public UserRepository()
        {
            users = new List<User>
            {
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid())
            };
        }

        public IUser GetUserById(Guid Id)
        {
            IUser userfound = users.SingleOrDefault(user => user.UserId == Id);

            //apply null object pattern here
            //if userfound is null, return your special kind of null user object
            if (userfound == null)
            {
                userfound = new NullUser();
            }

            return userfound;
        }

        public ICollection<User> users;
    }
}
