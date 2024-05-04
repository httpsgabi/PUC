using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna, matriculaAlunoMaiorNota = 0, notaFinal = 0;
            double maiorNota = 0, mediaNotasFinais = 0 ; 
            int[,] matriz = new int[10, 4];

            //Random rand = new Random();

            for(linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(coluna = 0; coluna < matriz.GetLength(1) - 1; coluna++)
                {
                   
                    if (coluna == 0)
                    {
                        Console.Write($"Matrícula: ");
                        matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    }
                    else if (coluna == 1)
                    {
                        Console.Write($"\nMédia das provas: ");
                        matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    }
                    else if (coluna == 2)
                    {
                        Console.Write($"\nMédia dos trabalhos: ");
                        matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine();
            }

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (coluna = 1; coluna < matriz.GetLength(1) - 1; coluna++)
                {
                    notaFinal = matriz[linha, 1] + matriz[linha, 2];  

                    if (notaFinal > maiorNota)
                    {
                        maiorNota = notaFinal;
                        matriculaAlunoMaiorNota = matriz[linha, 0];
                    }

                }
                matriz[linha, 3] = notaFinal;
                mediaNotasFinais += notaFinal;
                notaFinal = 0;
            }

            for (linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($"\t{matriz[linha, coluna]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"A média das notas finais é: {mediaNotasFinais/matriz.GetLength(0)}");
            Console.WriteLine($"O aluno com a maior nota possui esse número de matrícula: {matriculaAlunoMaiorNota}");

            Console.ReadLine();
        }
    }
}
