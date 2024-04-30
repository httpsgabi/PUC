using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz= new double[10,10];
            int linha, coluna;

            Random random = new Random();

            Console.WriteLine($"Matriz original: \n");

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(coluna = 0;coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = random.Next(0, 30);
                    Console.Write($"\t{matriz[linha, coluna]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            for (linha = 0, coluna = 0; linha < matriz.GetLength(0); linha++, coluna++)
            {
                matriz[linha,linha] = Math.Round(Math.Sqrt(matriz[linha,linha]), 2);

            }

            Console.WriteLine($"Matriz modificada: \n");

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($"\t{matriz[linha, coluna]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
