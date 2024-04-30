using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna;
            bool triagularSuperior = true;
            int[,] matriz = new int[4,4];

            for(linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {

                    Console.Write($"\nDigite um valor para a linha {linha} e coluna {coluna}: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Essa é a matriz: ");

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {

                    Console.Write($"\t {matriz[linha, coluna]} ");
                }

                Console.WriteLine();
            }

            for(linha = 1; linha < matriz.GetLength(0) ;linha++)
            {
                for (coluna = 0; coluna < linha; coluna++)
                {
                    if (matriz[linha, coluna] != 0)
                    {
                        triagularSuperior = false;
                    }
                }
                
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(triagularSuperior == false ? "Ela não é um triagular superior" : "Ela é triangular superior");
            Console.ReadLine();
        }
    }
}
