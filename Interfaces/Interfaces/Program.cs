
using Interfaces.Entities;
using System;
using System.Globalization;
namespace locadoraaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Locadora nova = new Locadora("Civic",DateTime.ParseExact("25/06/2018 10:30","dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture),DateTime.ParseExact("25/06/2018 14:40","dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture),10,130);
            Console.WriteLine(nova.ToString());
        }
    }
}