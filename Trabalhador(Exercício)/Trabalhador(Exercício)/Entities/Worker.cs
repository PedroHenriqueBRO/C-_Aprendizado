using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalhador_Exercício_.Entities.enums;
namespace Trabalhador_Exercício_.Entities
{
    public class Worker
    {
        public string? name {  get; set; }
        public WorkerLevel level { get; set; }

        public double baseSalary {  get; set; }

        public List<HourContract> hourscontracts { get; set; }=new List<HourContract>();

        public Departament departamento { get; set; }

        public void addContract(HourContract contrato)
        {
            
            hourscontracts.Add(contrato);

        }
        public void removeContract(HourContract contrato)
        {
            hourscontracts.Remove(contrato);
        }

        public double income(int year,int month)
        {
            double moneycontracts = 0;
            foreach (HourContract contract in hourscontracts)
            {
                if(contract.data.Month == month&& contract.data.Year == year)
                {
                    
                    moneycontracts=moneycontracts+(double)(contract.valuePerHour*contract.hour);
                }
            }
            
            return moneycontracts+baseSalary ;
        }
        public override string ToString()
        {
            return "Name : "+name+"\n"+"Departament : "+departamento.name + "\n"+"Money of contracts and base salary : ";
        }
    }
}
