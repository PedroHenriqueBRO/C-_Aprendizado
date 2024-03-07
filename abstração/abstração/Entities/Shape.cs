using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstração.Entities.enums;
namespace abstração.Entities
{
    abstract class Shape
    {
        public cores color {  get; protected set; }

        public Shape(cores color)
        {
            this.color = color;
        }
        public abstract double area();

        public override string ToString()
        {
            return $"Area : {area()}";
        }
    }
}
