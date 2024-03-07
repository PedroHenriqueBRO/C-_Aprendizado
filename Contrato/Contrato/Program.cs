using System;
using System.Globalization;
using Contrato.Entities;
namespace cc
{
    class Program
    {
        static void Main(string[] args)
        {
            Contratos novo = new Contratos(8028,DateTime.ParseExact("25/06/2018","dd/MM/yyyy",CultureInfo.InvariantCulture),600);
            PaypalService pys = new PaypalService();
            ContractService aaa = new ContractService(pys);
            aaa.processContract(novo, 3);
            novo.print();
        }
    }
}
