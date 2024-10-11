using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("1) Exibir quantidade de avioes");
            Console.WriteLine("2) Autorizar decolagem");
            Console.WriteLine("3) Adicionar aviao");
            Console.WriteLine("4) Listar fila");
            Console.WriteLine("5) Exibir primeiro da fila");
            Console.WriteLine("6) Sair");
        }
        static void Main(string[] args)
        {
            int opcao;
            string identificadorAviao;

            Fila avioes = new Fila(5);

            ExibirMenu();
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 6)
            {
                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Quantidade de avioes: " + avioes.ObterTamanho());

                        break;
                    case 2:

                        Console.WriteLine($"O aviao {avioes.Remover()} decolou");

                        break;
                    case 3:

                        Console.WriteLine("Digite o identificador do aviao:");
                        identificadorAviao = Console.ReadLine();

                        avioes.Inserir(identificadorAviao);

                        break;
                    case 4:

                        avioes.Mostrar();

                        break;
                    case 5:
                        Console.WriteLine("Primeiro aviao da fila: " + avioes.ObterPrimeiro());
                        break;
                }

                ExibirMenu();
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}

