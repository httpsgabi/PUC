using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, count, fatN = 1;
            double somaTotal = 1;
            
            Console.Write("Digite um valor n para calcular a soma: ");
            n = int.Parse(Console.ReadLine());

            for (count = 1; count <= n; count++)
            {
                fatN *= count;
                Console.WriteLine(fatN);

                somaTotal = somaTotal + (1.0 / fatN);

            }

            Console.WriteLine("A soma total é: " + somaTotal);
            
            Console.ReadLine();
        }
    }
}
