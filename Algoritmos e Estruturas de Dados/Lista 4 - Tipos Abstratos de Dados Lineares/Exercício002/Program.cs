using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {

        static void ExibirMenu()
        {
            Console.WriteLine("1) Inserir um produto no final da lista.");
            Console.WriteLine("2) Remover um produto especifico da lista.");
            Console.WriteLine("3) Listar os dados de todos os produtos da lista.");
            Console.WriteLine("4) Pesquisar se um produto ja consta na lista.");
            Console.WriteLine("5) Sair");
        }
        static void Main(string[] args)
        {
            string nomeProduto;
            int opcaoMenu, quantProduto;
            double precoProduto;
            Lista1 ListaDeProdutos = new Lista1(100);


            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 5)
            {

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto:");
                        nomeProduto = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade:");
                        quantProduto = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preco:");
                        precoProduto = double.Parse(Console.ReadLine());

                        Produto produto = new Produto(nomeProduto, quantProduto, precoProduto);

                        ListaDeProdutos.InserirFinal(produto);

                        break;
                    case 2:

                        Console.WriteLine("Digite o nome do produto a remover:");
                        nomeProduto = Console.ReadLine();

                        ListaDeProdutos.RemoverItem(nomeProduto);

                        break;
                    case 3:
                        Console.WriteLine("Lista de Produtos:");
                        ListaDeProdutos.Listar();

                        break;
                    case 4:
                        Console.WriteLine("Digite o nome que deseja pesquisar:");
                        string nomeItem = Console.ReadLine();

                        bool ehCadastrado = ListaDeProdutos.Pesquisar(nomeItem);

                        if (ehCadastrado)
                        {
                            Console.WriteLine("Produto Cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Produto não Cadastrado.");

                        }

                        break;
                    default:
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


