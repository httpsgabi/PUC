using Exercício003;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
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
            int opcaoMenu;
            Fila filaImpressao = new Fila();

            ExibirMenu();   
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 4)
            {
                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do arquivo:");
                        string nomeArquivo = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de paginas:");
                        int numPaginasArquivo = int.Parse(Console.ReadLine());

                        Arquivo arqvImpressao = new Arquivo(nomeArquivo, numPaginasArquivo);

                        filaImpressao.Inserir(arqvImpressao);

                        break;
                    case 2:
                        filaImpressao.Remover();
                        break;
                    case 3:
                        filaImpressao.Mostrar();
                        break;
                }

                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O programa sera encerrado.");
            Console.ReadLine();
        }
    }
}