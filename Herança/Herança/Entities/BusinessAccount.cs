using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    public class BusinessAccount : Account
    {
        public double loanLimit {  get; protected set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance,double loanLimit):base(number,holder,balance)
        {   
            this.loanLimit = loanLimit;
        }

        public void loan(double amount)
        {
            if(amount <=loanLimit)
            {
                balance += amount;
            }

        }

    }
}
