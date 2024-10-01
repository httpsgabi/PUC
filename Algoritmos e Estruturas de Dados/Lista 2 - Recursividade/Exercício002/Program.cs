using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static int SomarIntervalo(int num1, int num2)
        {
            int resultado;

            if (num1 > num2)
            {
                return 0;
            }
            else if (num1 == num2)
            {
                return num1;
            }

            return num1 + SomarIntervalo(num1 + 1, num2);
        }
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Digite dois números inteiros e positivos");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            resultado = SomarIntervalo(num1, num2);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
