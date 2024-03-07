using ConsoleApp1.Entities;
using System;
namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Site novo = new Site(@"C:\Users\xtron\Desktop\Logs\logs.txt");
            Console.WriteLine("Usuários totais : "+novo.usuariosdistintos());
        }
    }
}
