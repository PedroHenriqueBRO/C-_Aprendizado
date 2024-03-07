using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiamante.Entitites
{
    public abstract class Device
    {
        public string serialnumber {  get; set; }
        public abstract void processdoc();
    }
}
