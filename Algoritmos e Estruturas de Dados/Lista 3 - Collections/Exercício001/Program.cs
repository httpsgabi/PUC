using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("1) Inserir inicio");
            Console.WriteLine("2) Inserir fim");
            Console.WriteLine("3) Inserir posicao especifica");
            Console.WriteLine("4) Remover inicio");
            Console.WriteLine("5) Remover fim");
            Console.WriteLine("6) Remover posicao especifica");
            Console.WriteLine("7) Remover tempo especifico");
            Console.WriteLine("8) Pesquisar");
            Console.WriteLine("9) Mostrar");
            Console.WriteLine("10) Mostrar ordem crescente");
            Console.WriteLine("11) Mostrar ordem decrescente");
            Console.WriteLine("12) Encerrar");
        }

        static void InserirTempoInicio(List<double> TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

                TemposCorridas.Insert(0, tempo);
        }

        static void InserirTempoFinal(List<double> TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.Add(tempo);
        }

        static void InserirPosicaoEspecifica(List<double> TemposCorridas)
        {
            double tempo;
            int posicao;

            Console.WriteLine("Informe o tempo:");
            tempo= double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());

            if (posicao <= TemposCorridas.Count)
            {
                TemposCorridas.Insert(posicao, tempo);
            }
        }

        static void RemoverInicio(List<double> TemposCorridas)
        {
            TemposCorridas.RemoveAt(0);
        }

        static void RemoverFim(List<double> TemposCorridas)
        {
            if (TemposCorridas.Count > 0)
            {
                double tempoRemovido = TemposCorridas[TemposCorridas.Count - 1];
                TemposCorridas.RemoveAt(TemposCorridas.Count - 1);
                Console.WriteLine($"Tempo removido: {tempoRemovido}");
            }
        }
        static void RemoverPosicaoEspecifica(List<double> TemposCorridas)
        {
            int posicao;
            double tempoRemovido;

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());

            if (posicao > 0 && posicao <= TemposCorridas.Count)
            {
                tempoRemovido = TemposCorridas[posicao - 1];
                TemposCorridas.RemoveAt(posicao - 1);
                Console.WriteLine($"Tempo removido: {tempoRemovido}");
            }
        }

        static void RemoverTempoEspecifico(List<double> TemposCorridas)
        {
            double tempo;
            bool contem;
            int posicaoTempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            contem = TemposCorridas.Contains(tempo);

            if (contem)
            {
                posicaoTempo = TemposCorridas.IndexOf(tempo);
                TemposCorridas.RemoveAt(posicaoTempo);


                Console.WriteLine($"Tempo removido: {tempo}");
            }

        }

        static void Pesquisar(List<double> TemposCorridas)
        {
            double tempo;
            int quantidade = 0;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            foreach (var itemLista in TemposCorridas)
            {
                if(itemLista == tempo)
                {
                    quantidade++;
                }
            }

            Console.WriteLine($"Quantidade: {quantidade}");

        }
        static void Mostrar(List<double> TemposCorridas)
        {
            for (int i = 0; i < TemposCorridas.Count; i++)
            {
                Console.WriteLine($"{i}: {TemposCorridas[i]}");
            }
        }

        static void MostrarOrdemCrescente(List<double> TemposCorridas)
        {
            List<double> ListAux = new List<double>(TemposCorridas);

            ListAux.Sort();

            for (int i = 0; i < ListAux.Count; i++)
            {
                Console.WriteLine($"{i}: {ListAux[i]}");
            }
        }

        static void MostrarOrdemDecrescente(List<double> TemposCorridas)
        {
            List<double> ListAux = new List<double>(TemposCorridas);

            ListAux.Sort();

            for (int i = ListAux.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i}: {ListAux[i]}");
            }
        }

        static void Main(string[] args)
        {
            int opcaoMenu;
         
            List<double> TemposCorridas = new List<double>();

            ExibirMenu();

            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 12)
            {
               switch (opcaoMenu)
               {
                    case 1:
                        InserirTempoInicio(TemposCorridas);
                        break;
                    case 2:
                        InserirTempoFinal(TemposCorridas);
                        break;
                    case 3:
                        InserirPosicaoEspecifica(TemposCorridas);
                        break;
                    case 4:
                        RemoverInicio(TemposCorridas);
                        break;
                    case 5:
                        RemoverFim(TemposCorridas); 
                        break;
                    case 6:
                        RemoverPosicaoEspecifica(TemposCorridas);
                        break;
                    case 7:
                        RemoverTempoEspecifico(TemposCorridas);
                        break;
                    case 8:
                        Pesquisar(TemposCorridas);
                        break;
                    case 9:
                        Mostrar(TemposCorridas);
                        break;
                    case 10:
                        MostrarOrdemCrescente(TemposCorridas);
                        break;
                    case 11:
                        MostrarOrdemDecrescente(TemposCorridas);
                        break;
                    default:
                        Console.WriteLine("Posição Inválida");
                        break;
               }

               ExibirMenu();
               opcaoMenu = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fim");
        }
    }
}