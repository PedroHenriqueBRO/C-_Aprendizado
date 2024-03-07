using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiamante.Entitites
{
    public class ComboDevice : Device,IPrinter,IScanner
    {

        public ComboDevice() { }
        public override void processdoc()
        {
            Console.WriteLine( "processado");
        }
        public string scan(string a)
        {
            return a + ",scanneado";

        }
        public void printa(string a)
        {
            Console.WriteLine(a+",printado");
        }
    }
}
