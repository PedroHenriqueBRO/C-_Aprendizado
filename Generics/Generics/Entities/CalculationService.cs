using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class CalculationService
    {
        public CalculationService() { }
        public T max<G,T,A>(List<T> lista)where T  : Tupla<G,A> where A: IComparable where G : IComparable 
        {
            T maior = lista[0];
            foreach (T t in lista)
            {
                A amount2 = t.upla;
                if (amount2.CompareTo(maior.upla)>0)
                {
                    maior = t;
                }

            }
            return maior ;
        }
    }
}
