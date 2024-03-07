using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    public class SavingsAccount :Account
    {

        public double interestRate {  get; protected set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance,double interestRate): base(number,holder,balance)
        {
            this.interestRate = interestRate;
        }

        public void updateBalance()
        {
            balance += balance * interestRate;

        }
        public override void withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
