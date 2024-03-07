using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    public class Locadora
    {
        public string modelo{ get; set; }

        public DateTime dateinicial { get; set; }
        public DateTime datefinal { get; set; }
        public double valorhr { get;set; }
        public double valordia { get;set; }

        public Locadora(string modelo, DateTime dateinicial, DateTime datefinal, double valorhr, double valordia)
        {
            this.modelo = modelo;
            this.dateinicial = dateinicial;
            this.datefinal = datefinal;
            this.valorhr = valorhr;
            this.valordia = valordia;
        }

        public double valorlocacao()
        {
            TimeSpan horas = datefinal.Subtract(dateinicial);
            
            
            if (horas.TotalHours <= 12)
            {
                return valorhr * Math.Ceiling(horas.TotalHours);
            }
            else
            {
                return valordia*Math.Ceiling(horas.TotalDays);
            }
            
        }
        public double valorimposto()
        {
            double valor = valorlocacao();
            if (valor > 100)
            {
                valor =  valor * 0.15;
            }
            else
            {
                valor = valor * 0.20;
            }
            return valor;

        }
        public double valortotal()
        {
            return valorlocacao() + valorimposto();
        }
        public override string ToString()
        {
            return "Modelo : "+modelo+",valor locação : "+valorlocacao()+",valor imposto : "+valorimposto()+",valor total : "+valortotal();
        }
    }
}
