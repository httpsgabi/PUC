using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{

    using System;

    class TabelaHash
    {
        private int[] tabela;
        private int tamanho;

        public TabelaHash(int tamanho)
        {
            this.tamanho = tamanho;
            tabela = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                tabela[i] = -1; 
            }
        }
     
        private int Hash(int chave)
        {
            return chave % tamanho;
        }

        public void Inserir(int chave)
        {
            int pos = Hash(chave);
            int i = 0;
            bool inserido = false;

            while (i < tamanho && !inserido)
            {
                int novaPos = (pos + i) % tamanho;
                if (tabela[novaPos] == -1)
                {
                    tabela[novaPos] = chave;
                    Console.WriteLine($"Número {chave} inserido na posição {novaPos}.");
                    inserido = true; 
                }
                i++;
            }

            if (!inserido)
            {
                Console.WriteLine("Tabela cheia. Não foi possível inserir o número.");
            }
        }

      
        public void Remover(int chave)
        {
            int pos = Hash(chave);
            int i = 0;
            bool encontrado = false;

            while (i < tamanho && !encontrado) 
            {
                int novaPos = (pos + i) % tamanho;
                if (tabela[novaPos] == chave) 
                {
                    tabela[novaPos] = -1;
                    Console.WriteLine($"Número {chave} removido da posição {novaPos}.");
                    encontrado = true; 
                }
                else if (tabela[novaPos] == -1) 
                {
                    i = tamanho; 
                }
                i++;
            }

            if (!encontrado)
            {
                Console.WriteLine($"Número {chave} não encontrado.");
            }
        }

        public void Pesquisar(int chave)
        {
            int pos = Hash(chave);
            int i = 0;
            bool encontrado = false;

            while (i < tamanho && !encontrado)
            {
                int novaPos = (pos + i) % tamanho;
                if (tabela[novaPos] == chave) 
                {
                    Console.WriteLine($"Número {chave} encontrado na posição {novaPos}.");
                    encontrado = true; 
                }
                else if (tabela[novaPos] == -1) 
                {
                    i = tamanho; 
                }
                i++;
            }

            if (!encontrado)
            {
                Console.WriteLine($"Número {chave} não encontrado.");
            }
        }

        public void MostrarTabela()
        {
            Console.WriteLine("Tabela Hash:");
            for (int i = 0; i < tamanho; i++)
            {
                if (tabela[i] != -1)
                {
                    Console.WriteLine($"Posição {i}: {tabela[i]}");
                }
                else
                {
                    Console.WriteLine($"Posição {i}: vazio");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TabelaHash tabela = new TabelaHash(11);
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("1 - Inserir um número");
                Console.WriteLine("2 - Remover um número");
                Console.WriteLine("3 - Pesquisar um número");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o número a ser inserido: ");
                        int numeroInserir = int.Parse(Console.ReadLine());
                        tabela.Inserir(numeroInserir);
                        break;

                    case 2:
                        Console.Write("Digite o número a ser removido: ");
                        int numeroRemover = int.Parse(Console.ReadLine());
                        tabela.Remover(numeroRemover);
                        break;

                    case 3:
                        Console.Write("Digite o número a ser pesquisado: ");
                        int numeroPesquisar = int.Parse(Console.ReadLine());
                        tabela.Pesquisar(numeroPesquisar);
                        break;

                    case 4:
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                tabela.MostrarTabela();
            }

            Console.WriteLine("Programa encerrado.");
        }
    }


}
