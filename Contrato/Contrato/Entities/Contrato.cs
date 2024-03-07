using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entities
{
    public class Contratos
    {
        public int number { get; set; }

        public DateTime data { get; set; }
        public double totalvalue { get; set; }
        public List<Instalment> instalment { get; set; } = new List<Instalment>();

        public Contratos(int number, DateTime data, double totalvalue)
        {
            this.number = number;
            this.data = data;
            this.totalvalue = totalvalue;
           
        }
        public void print()
        {
            foreach(Instalment install in instalment)
            {
                Console.WriteLine(install.duedate.Date.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture) + "-" + install.amount);
            }
        }
    }
}
