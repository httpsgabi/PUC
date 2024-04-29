using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetA = new double[3];
            double[] vetB = new double[3];
            char[] vetC = new char[3];
            double[] vetD = new double[3];

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Digite o numero 1: ");
                vetA[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o numero 2: ");
                vetB[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a operação que deseja realizar: ");
                vetC[i] = char.Parse(Console.ReadLine());

                vetD[i] = vetC[i] == '+' ? (vetA[i] + vetB[i]) :
                          vetC[i] == '-' ? (vetA[i] - vetB[i]) :
                          vetC[i] == '/' ? (vetA[i] / vetB[i]) :
                          vetC[i] == '*' ? (vetA[i] * vetB[i]) :
                          double.NaN;

                if (double.IsNaN(vetD[i]))
                {
                    Console.WriteLine($"Operador inválido '{vetC[i]}'. Por favor, insira um dos seguintes operadores: '+', '-', '*', '/'");
                }

                Console.WriteLine($"-----------------------------------");
            }

            for (int i = 0; i < vetD.Length; i++)
            {
                Console.WriteLine($"Os resultados em ordem são: {i} - {vetD[i]} ");
            }

            Console.ReadLine();
        }
    }
}