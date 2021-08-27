using System;
using System.Linq;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
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

                        string senha = "123456";
                        string validaSenha;

                        Console.Write("Digite sua senha: ");
                        validaSenha = Console.ReadLine();

                        while (senha != validaSenha)
                        {
                            Console.WriteLine("Senha invalida!");
                            Console.Write("Digite novamente sua senha: ");
                            validaSenha = Console.ReadLine();
                        }

                        Console.WriteLine("Acesso permitido!");

                        break;

                    case 1:

                        int codigo, quantidade;
                        double preco = 0.0;

                        

                        Console.WriteLine("");
                        Console.WriteLine("Total: R$ {0:f2}", preco);

                        break;

                    case 2:

                        double PI = 3.141459;
                        double raio, area = 0.0;

                        Console.Write("Informe o raio do circulo : ");
                        raio = double.Parse(Console.ReadLine());

                        area = PI * (raio * raio);

                        Console.Write("Area do Circulo : " + area);

                        break;

                    default:
                        break;
                }
            } while (opcao != 5);

            Console.ReadKey();
        }

    }
}
   
