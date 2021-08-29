using System;
using System.IO;
using System.Linq;

namespace _2AulaFapen
{
    class Program
    {
        static void Main(string[] args
        {

            int opcao = 0;
            do
            {

                Console.WriteLine("Exercícios");

                Console.WriteLine();


                Enumerable.Range(0, 3).ToList().ForEach(x =>
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{x} - Resolvido");
                });


                Console.ResetColor();

                Console.WriteLine();

                Console.Write("Informe o número da questão que deseja apresentar: ");

                int.TryParse(Console.ReadLine(), out opcao);

                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        //EXERCICIO PARA VER SE DIRETORIO EXISTE E SE NAO EXISTIR ELE CRIA

                        string diretorio = @"C:\diretorioTeste1";


                        if (!Directory.Exists(diretorio))
                        {
                            Directory.CreateDirectory(diretorio);
                            Console.WriteLine($"Diretório {diretorio } criado");

                        }
                        else
                        {
                            Console.WriteLine($"Diretório {diretorio } já existe");
                        }
                        break;

                    case 1:

                        //EXERCICIO PARA CRIAR ARQUIVO TXT NO DIRETORIO

                        string aulaFapen = @"C:\diretorioTeste1\AulaFapen.txt";

                        try
                        {
                            using (StreamWriter writer = new StreamWriter(aulaFapen))
                            {
                                writer.Write("Estamos utilizando a classe StreamWriter para escrever esse código!");
                            }
                        }
                        catch (Exception exp)
                        {
                            Console.Write(exp.Message);
                        }

                        break;

                    case 2:

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

                        break;

                    default:
                        break;
                }
            } while (opcao != 4);

        }

    }

}



