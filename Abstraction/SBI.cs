using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;
namespace Abstraction
{
    internal class SBI : Bank
    {
        private double balance;

        
        public void CheckBalance()
        {
            Console.WriteLine($"The remaining balance in the account is {balance}");
        }

        public void Deposit(uint amount)
        {
            balance+= amount;
            Console.WriteLine("The amount deposited successfully ");
            CheckBalance();
        }

        public void Withdraw(uint amount)
        {
            if (amount >= balance)
                throw new Exception("The balance in the account is lessthan withdraw requested amount.... Transaction Failed");
            balance -= amount;
            Console.WriteLine("The amount withdrawn successfully ");
            CheckBalance();
        }
    }
}
