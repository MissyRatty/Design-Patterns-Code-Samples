namespace GOFDesignPatterns.Others.NullObjectPattern
{
    //Null User Class to handle User Objects that return null after a call to the UserRepository
    public class NullUser : IUser
    {
        public string Name => "unknown";

        //the methods in IUser are implemented to do basically noting
        public void IncrementSessionTicket()
        {
            //do nothing
        }
    }
}
