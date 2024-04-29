using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double somarLinhas = 0, somarColunas = 0, somarDiagonalPrincial = 0, somarDiagonalSecundaria = 0;

            Random random = new Random();


            Console.Write("\nDigite um numero para formar uma matriz: ");
            numero = int.Parse(Console.ReadLine());

            int[,] matriz = new int[numero, numero];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    int numeroAleatorio = random.Next(0, 10);

                    matriz[linha, coluna] = numeroAleatorio;

                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------------------------------");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    somarLinhas += matriz[linha, coluna];
                }

                Console.WriteLine($"A soma da {linha} linha é: {somarLinhas}");

                somarLinhas = 0;
            }
            Console.WriteLine("-------------------------------------------------------------------------");

            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    somarColunas += matriz[linha, col];
                }

                Console.WriteLine($"A soma da {col} coluna é: {somarColunas}");

                somarColunas = 0;
            }

            Console.WriteLine("-------------------------------------------------------------------------");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                somarDiagonalPrincial += matriz[linha, linha];
            }
            Console.WriteLine($"A soma da diagonal principal é: {somarDiagonalPrincial}");

            Console.WriteLine("-------------------------------------------------------------------------");

            for (int linha = 0, coluna = (matriz.GetLength(1) - 1); linha < matriz.GetLength(0); linha++, coluna--)
            {
                somarDiagonalSecundaria += matriz[linha, coluna];
            }

            Console.WriteLine($"A soma da diagonal secundária é: {somarDiagonalSecundaria}");

            Console.ReadLine();
        }
    }
}
