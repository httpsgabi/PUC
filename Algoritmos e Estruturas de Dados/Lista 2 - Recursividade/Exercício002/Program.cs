using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static int SomarIntervalo(int a, int b)
        {
            int num1 = a, num2 = b, soma; 

            if (num1 == num2)
            {
                soma = num1;
            }
            else{
                soma = num1 + SomarIntervalo(num1 + 1, num2);
            }

            return soma;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(SomarIntervalo(4, 7));
            Console.ReadLine();
        }
    }
}