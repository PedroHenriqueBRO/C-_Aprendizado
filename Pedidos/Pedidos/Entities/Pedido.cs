using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys.enums;
using Pedidos.Entities;
namespace Pedidos.Entities
{
    public class Pedido : Entidade{
        
        public DateTime momento { get; set; }

        public Orderstatus estado { get; set; }

        public override string ToString()
        {
            return "Id : " + id + ", momento : " + momento + " e estado : " + estado.ToString();
        }




    }
}
