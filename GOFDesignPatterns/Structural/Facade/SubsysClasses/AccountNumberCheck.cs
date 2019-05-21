namespace GOFDesignPatterns.Structural.Facade.SubsysClasses
{
    public class AccountNumberCheck
    {
        private static readonly int _accountNumber = 123456;

        public int GetAccountNumber => _accountNumber;

        public bool AccountActive(int accountNumber)
        {
            bool isActive = (accountNumber == GetAccountNumber) ? true : false;
            return isActive;
        }
    }
}
