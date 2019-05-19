using System.Collections.Generic;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    //This is the concrete mediator class
    public class FacebookChatRoom : Facebook
    {
        // keeps a reference to all the users (colleague objects)
        private Dictionary<string, FacebookUser> _skypeUsers = new Dictionary<string, FacebookUser>();

        //add new users to the list of skypeusers
        public override void Register(FacebookUser user)
        {
            if (!_skypeUsers.ContainsValue(user))
            {
                _skypeUsers[user.Name] = user;
            }

            //assign the new user to this SkypeChatRoom
            user.Chatroom = this;
        }

        public override void Send(string source, string destination, string message)
        {
            FacebookUser userToReceiveMsg = _skypeUsers[destination];
            if (userToReceiveMsg != null)
            {
                userToReceiveMsg.Receive(source, message);
            }
        }
    }
}
