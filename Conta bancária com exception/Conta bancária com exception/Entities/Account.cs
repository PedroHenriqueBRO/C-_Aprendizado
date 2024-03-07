using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conta_bancária_com_exception.Entities.Exceptions;
namespace Conta_bancária_com_exception.Entities
{
    public class Account
    {
        public int number { get; set; }
        public string name { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }

        public Account(int number, string name, double balance, double withdrawLimit)
        {
            this.number = number;
            this.name = name;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;
        }
        public void deposit(double amount)
        {
            balance += amount;
        }
        public void withdraw(double amount)
        {
            if (amount > withdrawLimit || amount > balance) throw new SaqueException("O valor de saque é maior que o limite ou maior que o conteúdo da conta");
            else
            {
                balance -= amount;
            }
           
        }
        public override string ToString()
        {
            return "Number : "+number+ ", Nome : "+name+ ", Balance : "+balance+", Withdraw : "+withdrawLimit;
        }
    }
}
