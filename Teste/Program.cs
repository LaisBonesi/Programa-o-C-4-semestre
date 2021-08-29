using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO PARA CONVERTER DADOS PARA UM VALOR INTEIRO
            double valor;

            try
            {
                Console.Write("Digite um valor: ");
              //  double.TryParse(Console.ReadLine(), out double valor);
                valor = double.Parse(Console.ReadLine());

                double numero = Convert.ToInt32(valor);

                // if (numero > 0)

                Console.WriteLine($"Deu certo, número inteiro {numero} ");

            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erro de soma" + ex.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Erro, não foi possível converter");
            }


        }

            }
    }

