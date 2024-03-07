using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class Tupla<T,A>
    {
        public T firt;
        public A upla;
        public Tupla(T firt, A upla)
        {
            this.firt = firt;
            this.upla = upla;
        }
        public override string ToString()
        {
            return "First value: "+firt+",Second Value:"+upla;
        }

    }
}
