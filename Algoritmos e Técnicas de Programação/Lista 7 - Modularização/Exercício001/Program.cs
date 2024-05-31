using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static int CalcMenorValor(int[] numeros)
        {
            int menorValor = 100000;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorValor)
                {
                    menorValor = numeros[i];
                }
            }

            return menorValor;
        }
        static void Main(string[] args)
        {
            int menorValor;

            int[] numeros = new int[4];

            Console.WriteLine($"Digite {numeros.Length} numeros para obter o menor deles: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            menorValor = CalcMenorValor (numeros);

            Console.WriteLine($"O menor valor é: {menorValor}");

            Console.ReadLine();
        }
    }
}
