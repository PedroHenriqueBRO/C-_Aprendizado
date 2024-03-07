using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_herança_e_polimorfismo_.Entities
{
     public class FuncionarioTercerizado : Funcionario
    {
        public double adicional {  get; protected set; }

        public FuncionarioTercerizado()
        {
        }

        public FuncionarioTercerizado(string nome, int hours, double valuePerHour,double adicional): base(nome,hours,valuePerHour)
        {
            this.adicional = adicional;
        }

        public override double payment()
        {
            return base.payment()+(double)(1.1*adicional);

        }
       
    }
}
