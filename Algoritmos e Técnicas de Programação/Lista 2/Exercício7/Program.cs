using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se ele é divisível por 3 e por 5");
            float numero = float.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Console.WriteLine("É divisível por 3 e 5");
            }
            else if (numero % 3 == 0)
            {
                Console.WriteLine("É divisível apenas por 3");
            }
            else if (numero % 5 == 0)
            {
                Console.WriteLine("É divisível apenas por 5");
            }
            else
            {
                Console.WriteLine("O número não possui divisão exata para nenhum dos 2 divisores");
            }

            Console.ReadLine();
        }
    }
}
