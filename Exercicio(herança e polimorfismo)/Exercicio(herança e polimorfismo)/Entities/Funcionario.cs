using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_herança_e_polimorfismo_.Entities
{
    public class Funcionario
    {
        public string nome { get; protected set; }
        public int hours { get; protected set; }

        public double valuePerHour { get; protected set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int hours, double valuePerHour)
        {
            this.nome = nome;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return (double)(valuePerHour*hours);
        }
        public override string ToString()
        {
            return nome + " - " + " $ " + payment();
        }
    }
}
