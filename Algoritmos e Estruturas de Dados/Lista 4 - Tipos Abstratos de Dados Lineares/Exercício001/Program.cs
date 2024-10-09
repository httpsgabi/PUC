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
            Console.WriteLine("10) Encerrar");
        }

        static void InserirTempoInicio(Lista1 TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.InserirInicio(tempo);
        }

        static void InserirTempoFinal(Lista1 TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.InserirFim(tempo);
        }

        static void InserirPosicaoEspecifica(Lista1 TemposCorridas)
        {
            double tempo;
            int posicao;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());

            TemposCorridas.Inserir(tempo, posicao);
        }

        static void RemoverInicio(Lista1 TemposCorridas)
        {
            TemposCorridas.RemoverInicio();
        }

        static void RemoverFim(Lista1 TemposCorridas)
        {
            Console.WriteLine($"Tempo removido: {TemposCorridas.RemoverFim()}");
        }
        static void RemoverPosicaoEspecifica(Lista1 TemposCorridas)
        {
            int posicao;

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());


            Console.WriteLine($"Tempo removido: {TemposCorridas.Remover(posicao)}");
        }

        static void RemoverTempoEspecifico(Lista1 TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.RemoverItem(tempo);

            Console.WriteLine($"Tempo removido: {tempo}");

        }

        static void Pesquisar(Lista1 TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Quantidade: {TemposCorridas.Contar(tempo)}");

        }
        static void Mostrar(Lista1 TemposCorridas)
        {
            TemposCorridas.Mostrar();
        }

        static void Main(string[] args)
        {
            int opcaoMenu;

            Lista1 TemposCorridas = new Lista1(100);

            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 10)
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
                    default:
                        Console.WriteLine("Posição Inválida");
                        break;
                }


                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }


}