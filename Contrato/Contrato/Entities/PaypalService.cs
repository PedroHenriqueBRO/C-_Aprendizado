using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entities
{
    public class PaypalService : OnlinePaymentService
    {
        public double payment(double amount) {
            
            return amount += (double)(0.02 * amount); 
        
        }
        public double interest(double amount, int months) {  
            return amount += (double)(0.01 * months * amount) ;
        }
    }
}
