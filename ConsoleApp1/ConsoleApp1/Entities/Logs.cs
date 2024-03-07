using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
     class Log
    {
        public string? nome {  get; set; }
        public DateTime instante { get; set; }

        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() == base.GetType()) {  
                Log log = obj as Log;
                return nome.Equals(log.nome);
            }
            return false;   
        }
        public override string ToString()
        {
            return "Nome: "+nome+",instante : "+instante;
        }
    }
}
