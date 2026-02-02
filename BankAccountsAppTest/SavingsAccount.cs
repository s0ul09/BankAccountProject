using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAppTest
{
    internal class SavingsAccount:BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner + $" ({interestRate}%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can't deposit $" + amount;
            }

            if (amount > 20000)
            {
                return "AML deposit limit reached.";
            }

            Balance += amount + ((InterestRate / 100) * amount);
            return "Succesfully deposited.";
        }
    }
}
