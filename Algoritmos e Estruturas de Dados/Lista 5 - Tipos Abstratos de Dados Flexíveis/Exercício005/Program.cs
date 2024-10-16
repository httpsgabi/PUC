using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
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
        static void InserirTempoInicio(ListaSimples TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.InserirInicio(tempo);
        }

        static void InserirTempoFinal(ListaSimples TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.InserirFim(tempo);
        }

        static void InserirPosicaoEspecifica(ListaSimples TemposCorridas)
        {
            double tempo;
            int posicao;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());

            TemposCorridas.Inserir(tempo, posicao);
        }

        static void RemoverInicio(ListaSimples TemposCorridas)
        {
            TemposCorridas.RemoverInicio();
        }

        static void RemoverFim(ListaSimples TemposCorridas)
        {
            Console.WriteLine($"Tempo removido: {TemposCorridas.RemoverFim()}");
        }
        static void RemoverPosicaoEspecifica(ListaSimples TemposCorridas)
        {
            int posicao;

            Console.WriteLine("Informe a posicao:");
            posicao = int.Parse(Console.ReadLine());


            Console.WriteLine($"Tempo removido: {TemposCorridas.RemoverPos(posicao)}");
        }

        static void RemoverTempoEspecifico(ListaSimples TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            TemposCorridas.RemoverItem(tempo);

            Console.WriteLine($"Tempo removido: {tempo}");

        }

        static void Pesquisar(ListaSimples TemposCorridas)
        {
            double tempo;

            Console.WriteLine("Informe o tempo:");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Quantidade: {TemposCorridas.Contar(tempo)}");

        }
        static void Mostrar(ListaSimples TemposCorridas)
        {
            TemposCorridas.Mostrar();
        }

        static void Main(string[] args)
        {
            int opcaoMenu;

            ListaSimples TemposCorridas = new ListaSimples();

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
        }
    }
}
