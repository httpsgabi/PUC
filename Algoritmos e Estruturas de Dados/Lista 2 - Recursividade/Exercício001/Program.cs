using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static int Potencia (int num1, int num2)
        {
            int resultado;

            if(num2 == 1)
            {
                resultado = num1;
            }
            else {
                resultado = num1 * Potencia(num1, num2 - 1);
            }

            return resultado;

        }
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Digite dois números inteiros e positivos");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());   

            resultado = Potencia(num1, num2);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
