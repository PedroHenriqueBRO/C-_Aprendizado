using System;
using System.Globalization;
using System.Collections.Generic;
using Vetores;
namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculadora.Sum(2,3,4,5,6));
            Console.WriteLine(Calculadora.Mult(3,4,5));
            Console.WriteLine(Calculadora.Div(6,3,2));


            List<int> novalista = new List<int>();
            novalista.AddRange(new[] { 1, 2, 4 ,3,3,5,6});
            novalista.ForEach(Console.WriteLine);
            Console.WriteLine(novalista.FindLast(x => x > 3));

            Produto [] produto = new Produto[3];

            for(int i = 0; i < 3; i++)
            {
                produto[i] = new Produto();
                produto[i].nomeproduto = Console.ReadLine();
                produto[i].preco =double.Parse(Console.ReadLine());
            }
            double precomedio = 0;
            for(int i = 0; i < 3; i++)
            {
                precomedio += produto[i].preco;
            }
            precomedio =(double)(precomedio/produto.Length);
            Console.WriteLine(precomedio);

            int positions = int.Parse(Console.ReadLine());
            double[] vector = new double[positions];
            for(int i=0; i < positions; i++)
            {
                vector[i]=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            }

            double media=0;

            for(int i=0;i<positions; i++)
            {
                media += vector[i];
            }
            media =(double)(media/positions);

            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

           
      
        }
    }
}
