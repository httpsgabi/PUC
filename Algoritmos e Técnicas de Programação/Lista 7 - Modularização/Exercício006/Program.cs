using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class Program
    {
        static void MultiplicarMatriz(int[,] matriz, int n)
        {
            Console.WriteLine("Matriz modificada: ");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] *= n;
                    Console.Write($"\t{matriz[linha, coluna]}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int linhas, colunas, n;
            Random random = new Random();

            Console.WriteLine($"Digite a quantidade de linhas e colunas da sua matriz:");
            Console.Write("Linhas: ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine($"Digite um inteiro n para multiplicar os numeros da sua matriz:");
            n = int.Parse(Console.ReadLine());

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = random.Next(0, 50);
                }
            }

            MultiplicarMatriz(matriz, n);

            Console.ReadLine();
        }
    }
}
