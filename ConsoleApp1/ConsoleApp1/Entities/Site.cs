using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
     class Site
    {
        private HashSet<Log> logo {  get; set; } = new HashSet<Log>();
        public Site(string path) { 
            using (StreamReader  sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    Log log = new Log();
                    string line = sr.ReadLine();
                    string[] sepair = line.Split(",");
                    log.nome = sepair[0];
                    log.instante = DateTime.ParseExact(sepair[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    logo.Add(log);
                    
                }
                
            }

        }

        public int usuariosdistintos()
        {

            int cont = 0;
            HashSet<Log> aux = new HashSet<Log>();
            foreach (Log log in logo)
            {
                if (aux.Contains(log) == false)
                {
                    cont++;
                }
                else
                {
                    aux.Add(log);
                }
            }
            foreach (Log log in aux)
            {
                Console.WriteLine(log);
            }
            return cont;
        }
    }
}
