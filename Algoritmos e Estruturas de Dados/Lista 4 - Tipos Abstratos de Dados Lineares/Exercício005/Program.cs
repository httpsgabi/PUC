using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("1. Inserir arquivo na fila de impressao");
            Console.WriteLine("2. Executar impressao");
            Console.WriteLine("3. Exibir fila de impressao");
            Console.WriteLine("4. Sair");

        }
        static void Main(string[] args)
        {
            int opcao;
            Fila fila = new Fila(100);

            ExibirMenu();
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do arquivo:");
                        string nomeArquivo = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de paginas:");
                        int numPaginas = int.Parse(Console.ReadLine());


                        Arquivo arquivo = new Arquivo(nomeArquivo, numPaginas);

                        fila.Inserir(arquivo); 

                        break;
                    case 2:
                        fila.Remover();
                        break;
                    case 3:
                        fila.Mostrar();
                        break;
                }

                ExibirMenu();
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O programa sera encerrado.");
            Console.ReadLine();
        }
    }
}