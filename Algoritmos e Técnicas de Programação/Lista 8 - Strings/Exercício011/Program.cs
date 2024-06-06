using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String dadosCSV;

            int quantLinhas = 0, quantCol = 0;

            string[] col;
            string[] rows;
            string[] vetDadosTemp;

            Console.WriteLine("Digite dados separados por vírgula, quando quiser diferenciar os dados das linhas, apenas tecle espaço: ");
            dadosCSV = Console.ReadLine();

            rows = dadosCSV.Split(' ');
            col = rows[0].Split(',');

            quantLinhas = rows.Length;
            quantCol = col.Length;


            string[,] matrizDados = new string[quantLinhas,quantCol];

            Console.WriteLine("\nA matriz gerada é: ");

            for (int i = 0; i < quantLinhas; i++)
            {
                vetDadosTemp = rows[i].Split(',');

                for (int j = 0; j < quantCol; j++)
                {
                    matrizDados[i,j] = vetDadosTemp[j];
                    Console.Write($"'{matrizDados[i, j]}' \t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
