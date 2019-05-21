namespace GOFDesignPatterns.Structural.Facade.SubsysClasses
{
    public class SecurityCodeCheck
    {
        private static readonly int _securityCode = 1234;

        public int GetSecurityCode => _securityCode;

        public bool IsCodeValid(int code)
        {
            bool isValid = (code == GetSecurityCode) ? true : false;
            return isValid;
        }
    }
}
