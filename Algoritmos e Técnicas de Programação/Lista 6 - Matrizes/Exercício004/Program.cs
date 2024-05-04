using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna, colunaCompImpar = 1;
            double[,] matriz = new double[3,6];
            double somarColunasImpares = 0, somarColunasPares = 0, mediaColunasPares = 0;

            Random random = new Random();

            Console.WriteLine("\nA matriz original é: \n");

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = random.Next(0, 10);
                    Console.Write($"\t{matriz[linha, coluna]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------------------------------");


            for (coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                for (linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    somarColunasImpares = coluna == colunaCompImpar ? somarColunasImpares += matriz[linha, coluna] : 0;
                    somarColunasPares = coluna % 2 == 0 ? somarColunasPares += matriz[linha, coluna] : 0;
                }

                if (coluna == colunaCompImpar)
                {
                    Console.WriteLine($"\nA soma da coluna {coluna} é: {somarColunasImpares}");

                    colunaCompImpar += 2;
                }

                if(coluna % 2 == 0 && coluna > 0)
                {
                    mediaColunasPares = somarColunasPares / matriz.GetLength(0);
                    Console.WriteLine($"\nA media da coluna {coluna} é: {Math.Round(mediaColunasPares, 2)}");
                }
               
                somarColunasImpares = 0;
                somarColunasPares = 0;
            }

            for (linha = 0, coluna = matriz.GetLength(1) - 1; linha < matriz.GetLength(0); linha++)
            {
                matriz[linha, coluna] = matriz[linha, 0] + matriz[linha, 1];
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("\nA matriz modificada é: \n");

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