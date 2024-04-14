using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            int contador = 0, subtrator = 1;

            Console.WriteLine("Digite um número para obter sua raiz quadrada: ");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                do
                {
                    num = num - subtrator;

                    if (num >= 0)
                    {
                        subtrator += 2;
                        contador++;
                    }
                } while (num >= 0);

                Console.WriteLine("A raiz quadrada é: " + contador);
            }
            else
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
            }

            Console.ReadLine();
        }
    }
}
