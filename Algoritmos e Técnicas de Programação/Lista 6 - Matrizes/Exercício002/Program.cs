using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna, numeroAleatorio;
            bool matrizesIguais = true;
            Random random = new Random();


            Console.Write($"\nDigite a quantidade de linha da matriz: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write($"\nDigite a quantidade de linha da matriz: ");
            coluna = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[linha, coluna];
            int[,] matrizB = new int[linha, coluna];

            for (linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    numeroAleatorio = random.Next(0, 2);
                    matrizA[linha, coluna] = numeroAleatorio;
                }
            }

            for (linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    numeroAleatorio = random.Next(0, 2);
                    matrizB[linha, coluna] = numeroAleatorio;
                }
            }

            for (linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    if (matrizA[linha, coluna] != matrizB[linha, coluna])
                    {
                        matrizesIguais = false;
                        break;
                    }
                }
                if (!matrizesIguais)
                    break;
            }

            Console.WriteLine("--------------------------------------------------\nMatriz A: ");
            for(linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    Console.Write($"\t{matrizA[linha, coluna]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------\nMatriz B: ");
            for (linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.Write($"\t{matrizB[linha, coluna]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(matrizesIguais == false ? "As matrizes são diferentes" : "As matrizes são iguais");
            Console.ReadLine();
        }
    }
}
