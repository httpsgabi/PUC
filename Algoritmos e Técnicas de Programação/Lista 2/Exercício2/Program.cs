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
            Console.WriteLine("Digite um numero entre 0 e 5 para saber sua escrita por extenso:");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 5) {
                if (num == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if (num == 1)
                {
                    Console.WriteLine("Um");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Dois");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Tres");
                }
                else if (num == 4)
                {
                    Console.WriteLine("Quatro");
                }
                else{
                    Console.WriteLine("Cinco");
                }
            }
            else
            {
                Console.WriteLine("Numero inválido");
            }

            Console.ReadLine();

        }
    }
}
