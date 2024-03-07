using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhador_Exercício_.Entities
{   public class HourContract
    {
        public DateTime data {  get; set; }
        public double valuePerHour {  get; set; }

        public int hour {  get; set; }

        public double totalValue()
        {
            return (double)(valuePerHour*hour);
        }
    }
}
