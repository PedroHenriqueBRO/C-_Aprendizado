using System;
using System.IO;
namespace testar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"d:\arquivos";
            string path = @"d:\arquivos\documento.txt";
            string targetpath = @"d:\arquivos\documentos2.txt";
            try
            {
                //printa diretorios dentro de um diretorio
                IEnumerable<string> c=Directory.EnumerateDirectories(pasta, "*.*", SearchOption.AllDirectories);
                foreach(string d in c)
                {
                    Console.WriteLine(d);
                }
                //printa todos os arquivos dentro de um diretório
                IEnumerable<string> fils = Directory.EnumerateFiles(pasta, "*.*", SearchOption.AllDirectories);
                foreach (string d in fils)
                {
                    Console.WriteLine(d);
                }
                //acessa o arquivo dado pelo path e utiliza do stream reader para ler
                using (StreamReader sr = File.OpenText(path))
                {
                    string[] s = sr.ReadToEnd().Split("\n");
                    foreach (string a2 in s)
                    {
                        Console.WriteLine(a2);
                    }
                }
                //Cria pasta
                Directory.CreateDirectory(pasta + @"\Novapasta");
                //acessa o arquivo pelo filestream que depois é convertido para Streamwriter para ser escrito algo nele
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Pedro henrique 19 anos");

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error," + e.ToString());
            }
            
        }

    }
}