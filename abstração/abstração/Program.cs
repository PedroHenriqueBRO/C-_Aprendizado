
using abstração.Entities;
using abstração.Entities.enums;
using System;
using System.Drawing;
namespace areas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Entre com a quantidade de shapes : ");

            int quant=int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine("C(circulo) ou R(retangulo) : ");

                string confirma=Console.ReadLine();
                if (confirma == "C")
                {
                    cores cor=Enum.Parse<cores>(Console.ReadLine());
                    double radiu = double.Parse(Console.ReadLine());
                    Shape shape = new Circulo(cor,radiu);
                    shapes.Add(shape);
                }
                else
                {
                    cores cor = Enum.Parse<cores>(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Shape shape = new Retangulo(cor, width,height);
                    shapes.Add(shape);

                }

            }
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}