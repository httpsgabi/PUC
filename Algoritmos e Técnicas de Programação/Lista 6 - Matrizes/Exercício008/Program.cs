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
            int linha, coluna, linhaJogador = 0, colunaJogador = 0, rodadas = 0;
            int[] contadorCaracter = new int[4];
            char[,] jogoDaVelha = new char[3, 3];


            while(alguemGanhou == false && rodadas <= 9){
                Console.Write($"Digite a linha e a coluna que deseja marcar o X: ");
                linhaJogador = int.Parse(Console.ReadLine());
                colunaJogador = int.Parse(Console.ReadLine());

                jogoDaVelha[linhaJogador, colunaJogador] = 'x';

                //Verifica se a diagonal princiapal tem 3 'x'
                for (linha = 0, coluna = 0; linha < jogoDaVelha.GetLength(0); linha++, coluna++)
                {
                    if (jogoDaVelha[linha, coluna] == 'x')
                    {
                        contadorCaracter[0] ++;
                    }
                }
                alguemGanhou = contadorCaracter[0] == 3 ? true : alguemGanhou;

                //Verifica se a diagonal secundária tem 3 'x'
                for (linha = 0, coluna = jogoDaVelha.GetLength(1) - 1; linha < jogoDaVelha.GetLength(0); linha++, coluna--)
                {
                    if (jogoDaVelha[linha, coluna] == 'x')
                    {
                        contadorCaracter[1]++;
                    }
                }

                alguemGanhou = contadorCaracter[1] == 3 ? true : alguemGanhou;

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

                    alguemGanhou = contadorCaracter[2] == 3 ? true : alguemGanhou;
                    contadorCaracter[2] = 0;
                }

                while (alguemGanhou == false)
                {
                    Console.Write($"Digite a linha e a coluna que deseja marcar o X: ");
                    linhaJogador = int.Parse(Console.ReadLine());
                    colunaJogador = int.Parse(Console.ReadLine());

                    jogoDaVelha[linhaJogador, colunaJogador] = 'o';
                }

                rodadas++;
            }

            Console.WriteLine(rodadas == 9 ? "O jogo empatou" : "O vencedor foi o jogador: ---");

            for (linha = 0; linha < jogoDaVelha.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < jogoDaVelha.GetLength(1); coluna++)
                {
                    Console.Write($"\t{jogoDaVelha[linha, coluna]} ");
                }
                Console.WriteLine();    
            }

            Console.ReadLine();
        }
    }
}
 