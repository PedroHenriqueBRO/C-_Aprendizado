using Herança.Entities;
using System;

namespace executar
{
    class Program
    {
        static void Main(string[] args)
        {
           BusinessAccount bcc= new BusinessAccount(1001,"Pedro",200,30);
            //upcasting
            Account acc = bcc;
            acc.withdraw(20);
            Console.WriteLine(acc.balance);
            
            Account acc4 = new SavingsAccount(1002, "joao", 0, 20);

            //downcasting
            BusinessAccount bcc2 = (BusinessAccount)acc;
            
            
            Account acc3 = new Account(1004,"ana",200);
            acc3.withdraw(15);
            Console.WriteLine(acc3.balance);

            //virtual,override e base
            Account sacc = new SavingsAccount(1005, "donatelo", 200,250);
            sacc.withdraw(15);
            
            Console.WriteLine(sacc.balance);


            

            

        }
    }
}
