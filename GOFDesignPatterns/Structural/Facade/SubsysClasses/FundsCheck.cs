using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Facade.SubsysClasses
{
    public class FundsCheck
    {
        private static double CashInAccount = 100.00d;

        public double GetCashInAccount => CashInAccount;

        public void DebitAccount(double amount)
        {
            CashInAccount -= amount;
        }

        public void CreditAccount(double amount)
        {
            CashInAccount += amount;
        }

        public bool HaveEnoughMoney(double amount)
        {
            if (amount > GetCashInAccount)
            {
                Console.WriteLine("Error: You don't have enough money to make this transaction");
                Console.WriteLine("Your Current Balance is: " + GetCashInAccount);

                return false;
            }
            else
            {
                DebitAccount(amount);
                Console.WriteLine("Withdrawal of " + amount + " has been completed. Your current Balance is " + GetCashInAccount);
                return true;
            }
            
        }

        public void MakeDeposit(double amount)
        {
            CreditAccount(amount);
            Console.WriteLine("Deposit of " + amount + " has been completed. Your current Balance is " + GetCashInAccount);
        }
    }
}
