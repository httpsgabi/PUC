using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercício005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna;
            double somaDiagonal = 0, somaDiagonalSec = 0, somatorioLinhas = 0, somatorioColunas = 0;
            bool LinhasIguais = true, colunasIguais = true; 
            int[,] quadradoPerfeito = new int[3, 3];

            Random random = new Random();

            Console.WriteLine($"A matriz é: ");

            for (linha = 0; linha < quadradoPerfeito.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < quadradoPerfeito.GetLength(1); coluna++)
                {
                    quadradoPerfeito[linha, coluna] = random.Next(0, 10);
                    Console.Write($"\t{quadradoPerfeito[linha, coluna]} ");
                }
                Console.WriteLine();
            }

            for (linha = 0, coluna = 0; linha < quadradoPerfeito.GetLength(0); linha++, coluna++)
            {
                somaDiagonal += quadradoPerfeito[linha, coluna];
            }

            for (linha = 0, coluna = quadradoPerfeito.GetLength(1) - 1; linha < quadradoPerfeito.GetLength(0); linha++, coluna--)
            {
                somaDiagonalSec += quadradoPerfeito[linha, coluna];
            }

            if (somaDiagonal == somaDiagonalSec)
            {
                for (linha = 0; linha < quadradoPerfeito.GetLength(0); linha++)
                {
                    for (coluna = 0; coluna < quadradoPerfeito.GetLength(1); coluna++)
                    {
                        somatorioLinhas += quadradoPerfeito[linha, coluna];
                    }

                    if (somaDiagonal != somatorioLinhas)
                    {
                        LinhasIguais = false;
                    }

                    somatorioLinhas = 0;
                }


                if (LinhasIguais == true)
                {
                    for (coluna = 0; coluna < quadradoPerfeito.GetLength(1); coluna++)
                    {
                        for (linha = 0; linha < quadradoPerfeito.GetLength(0); linha++)
                        {
                            somatorioColunas += quadradoPerfeito[linha, coluna];
                        }

                        if (somaDiagonal != somatorioColunas)
                        {
                            colunasIguais = false;
                        }

                        somatorioColunas = 0;
                    }

                    if (colunasIguais == true)
                    {
                        Console.WriteLine("A matriz é um quadrado perfeito");
                    }
                    else
                    {
                        Console.WriteLine("A matriz não é um quadrado perfeito");
                    }
                }
                else
                {
                    Console.WriteLine("A matriz não é um quadrado perfeito");
                }
            }
            else
            {
                Console.WriteLine("A matriz não é um quadrado perfeito");
            }

            Console.ReadLine();
        }
    }
}