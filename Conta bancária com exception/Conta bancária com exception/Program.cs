using Conta_bancária_com_exception.Entities;
using Conta_bancária_com_exception.Entities.Exceptions;
using System;
namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account Pedro = new Account(1002, "Pedro", 80, 50);
                Pedro.withdraw(60);
                Console.WriteLine(Pedro.ToString());

            }catch (SaqueException ex)
            {
                Console.WriteLine("Erro,"+ex.Message);
            }
        }
    }
}