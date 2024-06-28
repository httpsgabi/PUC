using Exercício001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            Cliente[] vet_clientes = new Cliente[3];
            string nome, endereco, metodoPagamento;
            long telefone;
            float totCompra = 100;


            Console.WriteLine("\nDeseja informar o método de pagamento?");
            opcao = char.Parse(Console.ReadLine());

            for (int i = 0; i < vet_clientes.Length; i++)
            {
                Console.Write($"\n\nDigite seu nome: ");
                nome = Console.ReadLine();

                Console.Write($"Digite seu endereço: ");
                endereco = Console.ReadLine();

                Console.Write($"Digite seu telefone: ");
                telefone = long.Parse(Console.ReadLine());

                if (opcao == 'n')
                {
                   vet_clientes[i] = new Cliente(nome, endereco, telefone);
                }
                else
                {
                    Console.Write($"Digite o método de pagamento: ");
                    metodoPagamento = Console.ReadLine();

                    vet_clientes[i] = new Cliente(nome, endereco, metodoPagamento, telefone, totCompra);
                }

                vet_clientes[i].MostrarInformacoes();
            }

            Console.ReadLine();
        }
    }
}

