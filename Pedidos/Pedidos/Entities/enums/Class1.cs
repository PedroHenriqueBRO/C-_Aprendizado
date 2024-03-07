using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.enums
{
   public enum Orderstatus : int
    {
        Pagamento_pendente = 0,
        Pago = 1,
        Processando = 2,
        Enviado = 3,
        Entregue = 4
    
    }
}
