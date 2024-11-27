using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercício002
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("1.Inserir um numero na arvore binaria de pesquisa");
            Console.WriteLine("2.Remover um numero da arvore binaria de pesquisa");
            Console.WriteLine("3.Pesquisar um numero na arvore binaria de pesquisa");
            Console.WriteLine("4.Mostrar o maior elemento da arvore binaria de pesquisa");
            Console.WriteLine("5.Mostrar o menor elemento da arvore binaria de pesquisa");
            Console.WriteLine("6.Mostrar todos os elementos da arvore, usando o caminhamento central");
            Console.WriteLine("7.Mostrar todos os elementos da arvore, usando o caminhamento pos-ordem");
            Console.WriteLine("8.Mostrar todos os elementos da arvore, usando o caminhamento pre-ordem");
            Console.WriteLine("9.Sair");

        }
        static void Main(string[] args)
        {

            int opcao;

            ExibirMenu();
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 9)
            {

            }

        }
    }
}
