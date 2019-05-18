using GOFDesignPatterns.Structural.Facade.SubsysClasses;
using System;

namespace GOFDesignPatterns.Structural.Facade.FacadeClass
{
    public class BankAccountFacade
    {
        //References to the sub system classes
        private readonly AccountNumberCheck _accountNumberChecker;
        private readonly SecurityCodeCheck _securityCodeChecker;
        private readonly FundsCheck _fundsChecker;

        private readonly WelcomeToBank _bankWelcome;

        public int GetAccountNumber { get; }

        public int GetSecurityCode { get; }

        public BankAccountFacade(int acctNumber, int securityCode)
        {
            GetAccountNumber = acctNumber;
            GetSecurityCode = securityCode;

            _bankWelcome = new WelcomeToBank();
            _accountNumberChecker = new AccountNumberCheck();
            _securityCodeChecker = new SecurityCodeCheck();
            _fundsChecker = new FundsCheck();
        }

        public void WithDrawCash(double cashToGet)
        {
            if (_accountNumberChecker.AccountActive(GetAccountNumber)
                && _securityCodeChecker.IsCodeValid(GetSecurityCode)
                && _fundsChecker.HaveEnoughMoney(cashToGet))
            {
                Console.WriteLine("Transaction Complete \n");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }

        public void DepositCash(double cashToDeposit)
        {
            if (_accountNumberChecker.AccountActive(GetAccountNumber)
                && _securityCodeChecker.IsCodeValid(GetSecurityCode))
            {
                _fundsChecker.MakeDeposit(cashToDeposit);
                Console.WriteLine("Transaction Complete \n");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
    }
}
