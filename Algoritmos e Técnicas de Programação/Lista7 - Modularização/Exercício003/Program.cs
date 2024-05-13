using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, n1, n2, n3;

            while( opcao != 3 )
            {

                Console.Write($"Digite a opção que deseja realizar: ");
                Console.WriteLine("1) Calcular MMC\r\n2) Calcular MDC\r\n3) Sair do programa");

                opcao = int.Parse(Console.ReadLine());

                if( opcao == 1)
                {
                    Console.Write("\nDigite o numero 1: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    
                }
                else if (opcao == 2)
                {
                    Console.Write("\nDigite o numero 1: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 3: ");
                    n3 = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}
