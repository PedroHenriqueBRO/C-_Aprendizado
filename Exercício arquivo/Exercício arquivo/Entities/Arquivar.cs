using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_arquivo.Entities
{
    public class Arquivar
    {
        public string Path { get; set; }
        public Arquivar(string path)
        {
            Path = path;
        }
        public void manipulaarquivo(string path)
        {
            using (StreamReader fs = new StreamReader(path))
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    string linhas=fs.ReadToEnd();
                    string[] linhaseparada = linhas.Split(",");
                    int cont = 0;
                    sw.WriteLine("NomeProduto,Preço,Quantidade");
                    foreach (string sa in linhaseparada)
                    {
                        
                        sw.Write(sa+",");
                        cont++;
                        if (cont == 2)
                        {
                            cont = 0;
                            
                        }else if(cont == 3)
                        {
                            sw.WriteLine();
                        }
                    }


                }
            }
            
        }
        public void lerarquivo()
        {
            using (StreamReader fs = new StreamReader(Path))
            {
               
            }
        }

    }
}
