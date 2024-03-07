using Generics.Entities;
using System;
namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tupla<string, int>> bbb = new List<Tupla<string, int>>();

            int quant = int.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                string a=Console.ReadLine();
                int b=int.Parse(Console.ReadLine());
                Tupla<string,int> aaa= new Tupla<string,int>(a,b);
                bbb.Add(aaa);

            }
            CalculationService calculationService = new CalculationService();
            Console.WriteLine(calculationService.max<string, Tupla<string, int>, int>(bbb).ToString());
        }
    }
}
