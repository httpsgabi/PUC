using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class Program
    {
        static void ListarMenu()
        {
            Console.WriteLine("1) Inserir fim");
            Console.WriteLine("2) Inserir inicio");
            Console.WriteLine("3) Inserir depois");
            Console.WriteLine("4) Remover inicio");
            Console.WriteLine("5) Remover fim");
            Console.WriteLine("6) Remover especifica");
            Console.WriteLine("7) Listar");
            Console.WriteLine("8) Pesquisar");
            Console.WriteLine("9) Sair");
        }
        static void Main(string[] args)
        {
            int opcaoMenu;
            string musica;

            LinkedList<string> musicas = new LinkedList<string>();

            ListarMenu();
            opcaoMenu = int.Parse(Console.ReadLine());  

            while (opcaoMenu != 9) {
                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Informe musica:");
                        musica = Console.ReadLine();

                        musicas.AddLast(musica);

                        break;
                    case 2:
                        Console.WriteLine("Informe musica:");
                        musica = Console.ReadLine();

                        musicas.AddFirst(musica);

                        break;
                    case 3:
                        Console.WriteLine("Informe musica:");
                        musica = Console.ReadLine();

                        Console.WriteLine("Informe musica que consta na lista:");
                        string musicaAddLast = Console.ReadLine();
                        var nodoReferencia = musicas.Find(musicaAddLast);

                        if (nodoReferencia != null)
                        {
                            musicas.AddAfter(nodoReferencia, musica);
                        }

                        break;
                    case 4:
                        musicas.RemoveFirst();

                        break;
                    case 5:
                        musicas.RemoveLast();

                        break;
                    case 6:
                        Console.WriteLine("Informe musica:");
                        musica = Console.ReadLine();

                        musicas.Remove(musica);

                        break;
                    case 7:
                        foreach (string s in musicas)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case 8:
                        Console.WriteLine("Informe musica:");
                        musica = Console.ReadLine();

                        if (musicas.Contains(musica))
                        {
                            Console.WriteLine("A musica esta na lista");
                        }
                        {
                            Console.WriteLine("A musica nao esta na lista");
                        }
                    break;
                }

                ListarMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim!");
            Console.ReadLine();
        }
    }
}
