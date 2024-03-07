using Exercício_arquivo.Entities;
using Microsoft.VisualBasic;
using System;
using System.IO;
namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorypath = @"D:\arquivos";
            string path = @"D:\arquivos\aaaa.csv";
            string newpath= @"D:\arquivos\out\bbbb.csv";
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    
                    
                    Directory.CreateDirectory(directorypath + @"\out");
                    using (StreamWriter sw = File.AppendText(newpath))
                    {
                        Arquivar novo =new Arquivar(@"D:\arquivos\out\cccc.csv");
                        novo.manipulaarquivo(@"D:\arquivos\aaaa.csv");
                        for (; !sr.EndOfStream;)
                        {
                            string s = sr.ReadLine();
                            string[] infos = s.Split(",");
                            Console.WriteLine("Nome do produto : " + infos[0]);
                            Console.WriteLine("Preço total : " + double.Parse(infos[1]) * double.Parse(infos[2]));
                            sw.WriteLine(infos[0]+","+"Preço total : "+ double.Parse(infos[1]) * double.Parse(infos[2]));
                        }
                        


                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
