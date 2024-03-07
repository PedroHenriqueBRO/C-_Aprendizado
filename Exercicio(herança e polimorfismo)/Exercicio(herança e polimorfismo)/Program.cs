using Exercicio_herança_e_polimorfismo_.Entities;
using System;
namespace Funcios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de funcionarios para serem lidos ");
            int quant=int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();
            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine("Deseja registrar um funcionario normal ou terceirizado : (N(normal) or T(terceirizado))");
                string confirma = Console.ReadLine();
                if(confirma == "N")
                {
                    string nome= Console.ReadLine(); 
                    int hours= int.Parse(Console.ReadLine());
                    double value= double.Parse(Console.ReadLine());

                    Funcionario funcionario = new Funcionario(nome,hours,value);                
               
                    lista.Add(funcionario);
                }
                else
                {
                    string nome = Console.ReadLine();
                    int hours = int.Parse(Console.ReadLine());
                    double value = double.Parse(Console.ReadLine());
                    double aditional = double.Parse(Console.ReadLine());

                    Funcionario funcionario = new FuncionarioTercerizado(nome, hours, value,aditional);
                    
                    lista.Add(funcionario);
                }
            }
            foreach (Funcionario funs in lista)
            {
                Console.WriteLine(funs.ToString());
            }



        }
    }
}
