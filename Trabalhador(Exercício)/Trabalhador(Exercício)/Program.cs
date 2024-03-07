using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Trabalhador_Exercício_.Entities;
using Trabalhador_Exercício_.Entities.enums;
namespace exceee
{
    class Program
    {
        static void Main(string[] args)
        {
            Departament departament = new Departament { 
            name=Console.ReadLine()
            };

            Worker worker = new Worker
            {
                departamento = departament,
                name=Console.ReadLine(),
                level=Enum.Parse<WorkerLevel>(Console.ReadLine()),
                baseSalary=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture)
            };

            Console.WriteLine("Quantos contratos deseja adicionar a esse trabalhador:");

            int quantidade=int.Parse(Console.ReadLine());
            for(int i=0; i<quantidade; i++)
            {
                 
                Console.WriteLine($"Enter the {i + 1} contract data :");
                Console.WriteLine($"Data : ");
                DateTime data1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);

                Console.WriteLine($"Value per hour : ");
                double valuePerHour1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Hours : ");
                int hour1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                worker.addContract(new HourContract { data=data1,hour=hour1,valuePerHour=valuePerHour1 });
            }
            Console.WriteLine("Enter the month and year :");
            DateTime mesano = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(worker + $" {worker.income(mesano.Year, mesano.Month)}");
            

            


        }
    }
}
