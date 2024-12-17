using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercício 9: Implemente um método que receba um vetor de jogadores(Jogador[]) como parâmetro e o ordene em ordem decrescente pela altura. A classe possui os seguintes atributos: id, nome, altura, peso, universidade, anoNasc, e estadoNasc.

	Ordene usando os 4 algoritmos de ordenação acima descritos. Descreva a principal vantagem de cada algoritmo e a principal descantagem.
 */

namespace Exercício9_Extra
{
    internal class Program
    {
        static void Selecao(Jogador[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int posMaior = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[posMaior].Altura < array[j].Altura)
                    {
                        posMaior = j;
                    }
                }

                Jogador temp = array[posMaior];
                array[posMaior] = array[i];
                array[i] = temp;

            }
        }

        static void BubbleSort(Jogador[] array)
        {
            for(int i = 0;i < array.Length - 1;)
            {
                for(int j = array.Length - 1; j > 0; j--)
                {
                    if (array[j].Altura > array[j-1].Altura)
                    {
                        Jogador temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        static void Insercao(Jogador[] array)
        {

        }

        static void QuickSort(Jogador[] array, int esq, int dir)
        {
            int i = esq, j = dir;
            double pivo = array[(esq + dir) / 2].Altura;

            while (i <= j)
            {
                while (array[i].Altura < pivo)
                {
                    i++;
                }
                while (array[j].Altura > pivo)
                {
                    j--;
                }
                if (i <= j)
                {
                    Jogador temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (esq < j)
            {
                QuickSort(array, esq, j);
            }
            if (dir > i)
            {
                QuickSort(array, i, dir);

            }
        }

        static void ImprimeOrdenados(Jogador[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Nome + ", ");
            }
        }
        static void Main(string[] args)
        {
            Jogador[] jogadores = new Jogador[4];
            

            jogadores[0] = new Jogador()
            {
                Id = 1,
                Nome = "João Silva",
                Altura = 1.85,
                Peso = 80,
                Universidade = "Universidade A",
                AnoNasc = 1995,
                EstadoNasc = "São Paulo"
            };

            jogadores[1] = new Jogador()
            {
                Id = 2,
                Nome = "Maria Oliveira",
                Altura = 1.72,
                Peso = 65,
                Universidade = "Universidade B",
                AnoNasc = 1993,
                EstadoNasc = "Rio de Janeiro"
            };

            jogadores[2] = new Jogador()
            {
                Id = 3,
                Nome = "Carlos Souza",
                Altura = 1.90,
                Peso = 95,
                Universidade = "Universidade C",
                AnoNasc = 1997,
                EstadoNasc = "Minas Gerais"
            };

            jogadores[3] = new Jogador()
            {
                Id = 4,
                Nome = "Fernanda Costa",
                Altura = 1.65,
                Peso = 70,
                Universidade = "Universidade D",
                AnoNasc = 1996,
                EstadoNasc = "Bahia"
            };

            Jogador[] copiaSelecao = jogadores;
            Jogador[] copiaBubble = jogadores;
            Jogador[] copiaInsercao = jogadores;
            Jogador[] copiaQuick = jogadores;

            Selecao(copiaSelecao);
            BubbleSort(copiaBubble);
            Insercao(copiaInsercao);
            QuickSort(copiaQuick, 0, copiaQuick.Length - 1);

            Console.WriteLine("Seleção: ");
            ImprimeOrdenados(copiaSelecao);

            Console.WriteLine("BubbleSort: ");
            ImprimeOrdenados(copiaBubble);

            Console.WriteLine("Inserção: ");
            ImprimeOrdenados(copiaInsercao);

            Console.WriteLine("QuickSort: ");
            ImprimeOrdenados(copiaQuick);

            Console.ReadLine();
        }
    }
}
