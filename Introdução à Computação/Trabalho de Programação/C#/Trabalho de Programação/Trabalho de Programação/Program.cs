using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Programação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoCliente = 0, quantProdutos, itemEscolhido = 0;
            float valorCompra = 0;

            Console.WriteLine("Seja bem vindo vendedor, iremos cadastrar seus produtos, digite quantos quer registrar: ");
            quantProdutos = int.Parse(Console.ReadLine());

            string[] nomesProdutos = new string[quantProdutos];
            float[] precoProduto = new float[quantProdutos];
            int[] idProduto = new int[quantProdutos];

            for (int i = 0;  i < quantProdutos; i++)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.Write($"\nNome do produto nº {i+1}: ");
                nomesProdutos[i] = Console.ReadLine();

                Console.Write($"\nPreço do produto nº{i+1}: ");
                precoProduto[i] = float.Parse(Console.ReadLine());

                idProduto[i] = i;
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Seja bem vindo cliente o que deseja fazer? ");
            Console.Write("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra \nOpção: ");
            opcaoCliente = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("---------------------------------------------------------");
                if (opcaoCliente == 1)
                {
                    for (int i = 0; i < quantProdutos; i++)
                    {
                        Console.WriteLine($"{idProduto[i]}\t|R$ {precoProduto[i]}\t | {nomesProdutos[i]}");
                    }

                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Digite o numero do item que deseja adicionar na sua sacola, e digite {quantProdutos} caso não queira comprar mais: ");

                    itemEscolhido = int.Parse(Console.ReadLine());

                    do
                    {
                        if((itemEscolhido < 0) && (itemEscolhido > quantProdutos))
                        {
                            Console.WriteLine("Item invalido, não está cadastrado. Digite um novo item");
                        }
                        else
                        {
                            for (int i = 0; i < quantProdutos; i++)
                            {
                                if (itemEscolhido == idProduto[i])
                                {
                                    valorCompra += precoProduto[i];
                                }
                            }
                            
                        }

                        Console.Write($"\nPróximo produto: ");
                        itemEscolhido = int.Parse(Console.ReadLine());

                    } while (itemEscolhido != quantProdutos);
                }
                else if(opcaoCliente != 0)
                {
                    Console.WriteLine("Digite uma opção válida! ");
                    opcaoCliente = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra: ");
                opcaoCliente = int.Parse(Console.ReadLine());

            } while (opcaoCliente != 2);

            Console.WriteLine($"O valor da compra é: {valorCompra}, obrigada e volte sempre! ");

            Console.ReadLine();
        }
    }
}

