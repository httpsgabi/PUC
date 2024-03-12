using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 1 e 4 para imprimir seu valor por extenso: ");
            int num = int.Parse(Console.ReadLine());

            switch (num) {            
                case 1:
                    Console.WriteLine("Um");
                break;
                case 2:
                    Console.WriteLine("Dois");
                break;
                case 3:
                    Console.WriteLine("Três");
                break;
                case 4:
                    Console.WriteLine("Quatro");
                break;
                default:
                    Console.WriteLine("Número inválido");
                break;

            }
            Console.ReadLine();

        }
    }
}

