using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static int Potencia (int a, int n)
        {
            int res = a, count = n;

            if (count == 1) {
                res = a;
            }
            else
            {
                res = a * Potencia(res, count - 1);
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Potencia(3, 3));

            Console.WriteLine(14%7);

            Console.ReadLine();
        }
    }
}
