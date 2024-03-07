using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    public class Account
    {
        public int number {  get; protected set; }
        public string holder {  get; protected set; }
        public double balance {  get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public virtual void withdraw(double amount)
        {
            balance -= amount + 5;

        }
        public void deposit(double amount)
        {
            balance += amount;
        }
    }
}
