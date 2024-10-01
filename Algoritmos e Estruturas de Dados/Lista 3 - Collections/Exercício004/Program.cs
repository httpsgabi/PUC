using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void ExibirOpcoes()
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

            Queue<string> avioes = new Queue<string>();

            ExibirOpcoes();
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 6)
            {
                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Quantidade de avioes: " + avioes.Count);

                        break;
                    case 2:

                        Console.WriteLine($"O aviao {avioes.Dequeue()} decolou");

                        break;
                    case 3:

                        Console.WriteLine("Digite o identificador do aviao:");
                        identificadorAviao = Console.ReadLine();

                        avioes.Enqueue(identificadorAviao);

                        break;
                    case 4:

                        foreach (string aviao in avioes)
                        {
                            Console.WriteLine(aviao);
                        }

                        break;
                    case 5:
                        Console.WriteLine("Primeiro aviao da fila: " + avioes.Peek());
                        break;
                }

                ExibirOpcoes();
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
