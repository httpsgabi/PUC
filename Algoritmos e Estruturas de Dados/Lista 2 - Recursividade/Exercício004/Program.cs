using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static int Mdc(int num1, int num2)
        {
            int maior, menor;

            if (num1 == num2)
            {
                return num1;
            }

            if (num1 > num2)
            {
                maior = num1;
                menor = num2;
            }
            else
            {
                maior = num2;
                menor = num1;
            }

            return Mdc(maior - menor, menor);
        }
        static void Main(string[] args)
        {
            int mdc, num1, num2; 

            Console.WriteLine("Digite dois numeros para calcular o mdc: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            mdc = Mdc(num1, num2);

            Console.WriteLine(mdc);

            Console.ReadLine();
        }
        
    }
}
