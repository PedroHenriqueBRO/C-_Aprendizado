using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entities
{
    public class Instalment
    {
        public DateTime duedate {  get; set; }
        public double amount { get; set; }

        public Instalment(DateTime duedate, double amount)
        {
            this.duedate = duedate;
            this.amount = amount;
        }
    }
}
