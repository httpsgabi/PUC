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
            int n, count = 1, fat = 1;
            double div, somaTotal = 1;
            

            Console.Write("Digite um valor n para calcular a soma: ");
            n = int.Parse(Console.ReadLine());

            do
            {
                fat = fat * count;

                count++;

                div = 1 / fat;
                somaTotal = somaTotal + div;
                    
            } while (count <= n);

            Console.WriteLine("o valor da soma é: " + somaTotal);

            Console.ReadLine();
        }
    }
}
