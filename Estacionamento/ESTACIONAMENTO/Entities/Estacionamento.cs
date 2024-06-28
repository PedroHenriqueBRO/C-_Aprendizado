using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ESTACIONAMENTO.Entities
{
    internal class Estacionamento
    {
        public decimal precoinicial  { get; set;}
        public decimal precoHora { get; set; }
        public List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoinicial,decimal precoHora) {
            this.precoinicial = precoinicial;
            this.precoHora = precoHora;
        }
        public void addVeiculo(string veiculo)
        {
            veiculos.Add(veiculo);
        }
        public void removeVeiculo(string veiculo)
        {
            if(veiculos.Contains(veiculo))
            {
                decimal horas =Decimal.Parse(Console.ReadLine());
                decimal preco = precoinicial + precoHora * (horas);
                veiculos.Remove(veiculo);
                Console.WriteLine($"Seu veículo foi removido e sua taxa de estacionamento foi : {preco}R$");
            }
            else
            {
                Console.WriteLine("Esse veículo não está nesse estacionamento");
            }

        }
        public void listarVeiculos()
        {
            foreach (string veiculo in veiculos)
            {
              
                Console.WriteLine(veiculo);
            }
        }




 
    }
}
