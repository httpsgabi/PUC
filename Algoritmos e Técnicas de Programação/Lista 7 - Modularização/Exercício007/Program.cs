using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
{
    internal class Program
    {
        static double CalcS(int n)
        {
            double s = 1, count = 2.0;

            for (int i = 2; i <= n; i++)
            {
                s += + (1 / count);
                count++;
            }

            return s;
        }
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite o número: ");
            n = int.Parse(Console.ReadLine());

            Console.Write($"O valor da soma é: {Math.Round(CalcS(n), 2)}");

            Console.ReadLine();
        }
    }
}
