using ProblemaDiamante.Entitites;
using System;
namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ComboDevice();
            IScanner printer2 = new ComboDevice();
            printer.printa("aaa");
            Console.WriteLine(printer2.scan("aaaaaaa"));

        }
    }
}
