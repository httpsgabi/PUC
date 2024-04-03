using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 1, temp = 0, numMax;

            Console.Write("Digite um valor para obter todos os números da sequência Fibonnaci menores que ele: ");
            numMax = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            while ((temp = a + b) < numMax)
            {
                temp = a + b;
                a = b;
                b = temp; ;
                Console.WriteLine(temp);                              
            }

            Console.ReadLine();
        }
    }
}
