using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool alguemGanhou = false;
            int linha, coluna, linhaJogador = 0, colunaJogador = 0, rodadas = 1;
            char vencedor = '\0'; 
            int[] contadorCaracter = new int[8];
            char[,] jogoDaVelha = new char[3, 3];

            for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                {
                    jogoDaVelha[linha, coluna] = '-';
                }
            }

            Console.WriteLine($"Bem vindo ao jogo da velha");

            while (alguemGanhou == false && rodadas <= 9)
            {
                Console.Write($"Linha do X: ");
                linhaJogador = int.Parse(Console.ReadLine());
                Console.Write($"Coluna do X: ");
                colunaJogador = int.Parse(Console.ReadLine());

                jogoDaVelha[linhaJogador, colunaJogador] = 'x';

                for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                {
                    for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                    {
                        Console.Write($"\t{jogoDaVelha[linha, coluna]} ");
                    }
                    Console.WriteLine();
                }

                //Verifica se a diagonal princiapal tem 3 'x'
                for (linha = 0, coluna = 0; linha < jogoDaVelha.GetLength(0); linha++, coluna++)
                {
                    if (jogoDaVelha[linha, coluna] == 'x')
                    {
                        contadorCaracter[0]++;                       
                    }
                }
                alguemGanhou = contadorCaracter[0] == 3 ? true : alguemGanhou;
                vencedor = contadorCaracter[0] == 3 ? 'X' : vencedor;

                //Verifica se a diagonal secundária tem 3 'x'
                for (linha = 0, coluna = jogoDaVelha.GetLength(1) - 1; linha < jogoDaVelha.GetLength(0); linha++, coluna--)
                {
                    if (jogoDaVelha[linha, coluna] == 'x')
                    {
                        contadorCaracter[1]++;
                    }
                }

                alguemGanhou = contadorCaracter[1] == 3 ? true : alguemGanhou;
                vencedor = contadorCaracter[1] == 3 ? 'X' : vencedor;

                //Verifica se as colunas tem 3 'x'
                for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                {
                    for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                    {
                        if (jogoDaVelha[linha, coluna] == 'x')
                        {
                            contadorCaracter[2]++;
                        }
                    }

                    alguemGanhou = contadorCaracter[2] == 3 ? true : alguemGanhou;
                    vencedor = contadorCaracter[2] == 3 ? 'X' : vencedor;
                    contadorCaracter[2] = 0;
                }

                //Verifica se as linhas tem 3 'x'
                for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                {
                    for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                    {
                        if (jogoDaVelha[linha, coluna] == 'x')
                        {
                            contadorCaracter[3]++;
                        }
                    }

                    alguemGanhou = contadorCaracter[3] == 3 ? true : alguemGanhou;
                    vencedor = contadorCaracter[3] == 3 ? 'X' : vencedor;
                    contadorCaracter[3] = 0;
                }

                if (alguemGanhou == false && rodadas < 9)
                {
                    rodadas++;
                    Console.WriteLine($"------------------------------------------");
                    Console.Write($"Linha do O: ");
                    linhaJogador = int.Parse(Console.ReadLine());
                    Console.Write($"Coluna do O: ");
                    colunaJogador = int.Parse(Console.ReadLine());
                    
                    jogoDaVelha[linhaJogador, colunaJogador] = 'o';

                    for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                    {
                        for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                        {
                            Console.Write($"\t{jogoDaVelha[linha, coluna]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"------------------------------------------");

                    //Verifica se a diagonal princiapal tem 3 'O'
                    for (linha = 0, coluna = 0; linha < jogoDaVelha.GetLength(0); linha++, coluna++)
                    {
                        if (jogoDaVelha[linha, coluna] == 'o')
                        {
                            contadorCaracter[4]++;
                        }
                    }
                    alguemGanhou = contadorCaracter[4] == 3 ? true : alguemGanhou;
                    vencedor = contadorCaracter[4] == 3 ? 'O' : vencedor;

                    //Verifica se a diagonal secundária tem 3 'O'
                    for (linha = 0, coluna = jogoDaVelha.GetLength(1) - 1; linha < jogoDaVelha.GetLength(0); linha++, coluna--)
                    {
                        if (jogoDaVelha[linha, coluna] == 'o')
                        {
                            contadorCaracter[5]++;
                        }
                    }

                    alguemGanhou = contadorCaracter[5] == 3 ? true : alguemGanhou;
                    vencedor = contadorCaracter[5] == 3 ? 'O' : vencedor;

                    //Verifica se as colunas tem 3 'O'
                    for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                    {
                        for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                        {
                            if (jogoDaVelha[linha, coluna] == 'o')
                            {
                                contadorCaracter[6]++;
                            }
                        }

                        alguemGanhou = contadorCaracter[6] == 3 ? true : alguemGanhou;
                        vencedor = contadorCaracter[6] == 3 ? 'O' : vencedor;
                        contadorCaracter[6] = 0;
                    }

                    //Verifica se as linhas tem 3 'O'
                    for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                    {
                        for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
                        {
                            if (jogoDaVelha[linha, coluna] == 'o')
                            {
                                contadorCaracter[7]++;
                            }
                        }

                        alguemGanhou = contadorCaracter[7] == 3 ? true : alguemGanhou;
                        vencedor = contadorCaracter[7] == 3 ? 'O' : vencedor;
                        contadorCaracter[7] = 0;
                    }
                    
                }

                Array.Clear(contadorCaracter, 0, contadorCaracter.Length);
                rodadas++;
            }

            Console.WriteLine($"\n------------------------------------------");
            Console.WriteLine(alguemGanhou == false ? "Resultado: O jogo empatou" : $"Resultado: O vencedor foi o jogador: {vencedor}");

            Console.ReadLine();
        }
    }
}
