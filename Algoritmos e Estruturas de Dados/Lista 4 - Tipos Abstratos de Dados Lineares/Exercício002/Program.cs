using System;
using System.Collections.Generic;
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
            int opcaoMenu;

            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 5) {

                switch (opcaoMenu)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
