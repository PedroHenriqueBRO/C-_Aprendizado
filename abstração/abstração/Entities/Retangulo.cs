using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstração.Entities.enums;
namespace abstração.Entities
{
    class Retangulo : Shape
    {
        public double width {  get; protected set; }
        public double height { get; protected set; }

        public Retangulo(cores color,double width,double height) : base(color){ 
            this.width = width;
            this.height = height;
        
        }
        public override double area()
        {
            return width*height;
        }
    }
}
