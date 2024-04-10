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
            int num, contador = 1;
            double a = 1, b = 1, temp;

            Console.Write("Digite um valor para calcular a sua sequência Fibonnaci: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            
            while (contador < num-1)
            {
                temp = a + b;
                a = b;
                b = temp; ;
                contador++;
                Console.WriteLine(temp);                
            }

            Console.ReadLine();
        }
    }
}
