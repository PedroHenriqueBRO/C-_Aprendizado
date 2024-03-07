using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entities
{
    public interface OnlinePaymentService
    {
        public double payment(double amount);
        public double interest(double amount,int months);
    }
}
