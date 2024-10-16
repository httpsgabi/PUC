using Exercício006;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Inserir um Site no inicio da lista");
            Console.WriteLine("2) Inserir um Site no final da lista");
            Console.WriteLine("3) Inserir um Site numa posicao especifica da lista");
            Console.WriteLine("4) Remover o primeiro Site da lista");
            Console.WriteLine("5) Remover o ultimo Site da lista");
            Console.WriteLine("6) Remover um Site de uma posicao especifica da lista");
            Console.WriteLine("7) Mostrar o nome e o link de todos os sites da lista");
            Console.WriteLine("8) Pesquisar o link de um site");
            Console.WriteLine("9) Encerrar o programa");

        }
        static void Main(string[] args)
        {
            int opcaoMenu, posSite;
            string nomeSite, linkSite;

            Site site;
            ListaSimples listaSites = new ListaSimples();

            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 9)
            {
                switch (opcaoMenu)
                {
                    case 1:

                        Console.WriteLine("Informe o nome do site:");
                        nomeSite = Console.ReadLine();

                        Console.WriteLine("Informe o link do site:");
                        linkSite = Console.ReadLine();

                        site = new Site(nomeSite, linkSite);
                        listaSites.InserirInicio(site);

                        break;
                    case 2:

                        Console.WriteLine("Informe o nome do site:");
                        nomeSite = Console.ReadLine();

                        Console.WriteLine("Informe o link do site:");
                        linkSite = Console.ReadLine();

                        site = new Site(nomeSite, linkSite);
                        listaSites.InserirFim(site);

                        break;
                    case 3:
                        Console.WriteLine("Informe o nome do site:");
                        nomeSite = Console.ReadLine();

                        Console.WriteLine("Informe o link do site:");
                        linkSite = Console.ReadLine();

                        Console.WriteLine("Informe a posicao:");
                        posSite = int.Parse(Console.ReadLine());

                        site = new Site(nomeSite, linkSite);
                        listaSites.Inserir(site, posSite);

                        break;
                    case 4:

                        site = listaSites.RemoverInicio();

                        Console.WriteLine($"Site removido: {site.Nome}");

                        break;
                    case 5:

                        site = listaSites.RemoverFim();

                        Console.WriteLine($"Site removido: {site.Nome}");

                        break;
                    case 6:
                        Console.WriteLine("Informe a posicao:");
                        posSite = int.Parse(Console.ReadLine());

                        site = listaSites.RemoverPos(posSite);

                        Console.WriteLine($"Site removido: {site.Nome}");

                        break;
                    case 7:

                        listaSites.Mostrar();

                        break;
                    case 8:
                        Console.WriteLine("Informe o nome do site:");
                        nomeSite = Console.ReadLine();

                        Console.WriteLine($"Link: {listaSites.Pesquisar(nomeSite)}");

                        break;
                }


                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O programa sera encerrado.");
        }

    }
}