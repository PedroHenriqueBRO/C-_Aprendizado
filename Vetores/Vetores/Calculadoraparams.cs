using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    static public class Calculadora
    {
        static public double Sum(params double[] numbs)
        {
            double sum = 0;
            foreach (int bs in numbs)
            {
                sum += bs;
            }
            return sum;
        }
        static public double Mult(params double[]numbs)
        {
            double result = 1;
            foreach (int bs in numbs)
            {
                result *= bs;
            }
            return result;
        }
        static public double Div(params double[]numbs)
        {
            double result = numbs[0];
           
            for(int i=1; i < numbs.Length; i++)
            {
                result/= numbs[i];
            }
            return result;
             
        }

    }
}

