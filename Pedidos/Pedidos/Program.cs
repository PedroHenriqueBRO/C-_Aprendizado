using Pedidos.Entities;
using System;
using Entitys.enums;
using System.Globalization;
namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedir = new Pedido
            {
                id = 1,
                momento = DateTime.ParseExact("31/03/2004 15:20:00","dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                estado = Orderstatus.Processando
            };
            
            Console.WriteLine(pedir);
        }
    }
}
