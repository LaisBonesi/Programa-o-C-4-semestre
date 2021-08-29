using System;
using System.IO;

namespace LerExerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO PARA LER ARQUIVO TXT NO DIRETORIO

            string linha;
           // using (StreamReader reader = new StreamReader(@"C:\diretorioTeste1\teste.txt"))
            using (StreamReader reader = new StreamReader(@"C:\diretorioTeste1\AulaFapen.txt"))
            {
                {
                    linha = reader.ReadLine();
                }
                Console.WriteLine(linha);
            }
        }
    }
}
