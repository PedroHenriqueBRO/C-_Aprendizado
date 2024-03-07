using abstração.Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstração.Entities
{
     class Circulo : Shape
    {
        public double radius {  get; protected set; }

        public Circulo(cores color,double radius): base(color)
        {
            this.radius = radius;
        }
        public override double area()
        {
            double pi = 3.14;
            return pi*(radius*radius);
        }

    }
}
