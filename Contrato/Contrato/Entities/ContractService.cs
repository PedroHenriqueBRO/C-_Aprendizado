using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entities
{
    public class ContractService
    {
        public OnlinePaymentService OnlinePaymentService { get; set; }

        public ContractService(OnlinePaymentService onlinePaymentService)
        {
            OnlinePaymentService = onlinePaymentService;
        }
        public void processContract(Contratos contract ,int month)
        {
            for(int i=1;i<month+1;i++)
            {
                double amount = OnlinePaymentService.interest((double)(contract.totalvalue / month), i);
                amount = OnlinePaymentService.payment(amount);
                DateTime nova = contract.data;
                nova=nova.AddMonths(i);
                Instalment parcela = new Instalment(nova,amount);
                contract.instalment.Add(parcela);
            }

        }
    }
}
