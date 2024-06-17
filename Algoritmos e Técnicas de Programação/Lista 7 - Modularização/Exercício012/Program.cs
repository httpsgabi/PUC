using System;

namespace Exercício012
{
    internal class Program
    {
        static int AnalizaMatriz(int[,] matriz, out int linhaMaiorElem, out int colMaiorElem)
        {
            int maiorElemento = 0;
            linhaMaiorElem = 0;
            colMaiorElem = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > maiorElemento)
                    {
                        maiorElemento = matriz[i,j];
                        linhaMaiorElem = i;
                        colMaiorElem = j;
                    }
                }
            }

            return maiorElemento;
        }
        static void Main(string[] args)
        {
            int tamMatriz;
            Random random = new Random();

            Console.Write("\nDigite o tamanho da matriz que deseja criar: ");
            tamMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamMatriz,tamMatriz];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                }
            }

            int maiorElemento = AnalizaMatriz(matriz, out int linhaMaiorElem, out int colMaiorElem);

            Console.WriteLine($"O maior elemento é: {maiorElemento} \nA linha é: {linhaMaiorElem} \nE a coluna é: {colMaiorElem}");
            Console.ReadLine();
        }
    }
}
