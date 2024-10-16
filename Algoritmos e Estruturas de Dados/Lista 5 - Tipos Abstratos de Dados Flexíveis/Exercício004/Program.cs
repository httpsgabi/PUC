using Exercício004;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void ExibirMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Inserir um aluno na fila de espera de bolsas de IC");
            Console.WriteLine("2. Inserir um aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("3. Remover um aluno da fila de bolsas de IC");
            Console.WriteLine("4. Remover um aluno da fila de bolsas de Mestrado");
            Console.WriteLine("5. Mostrar fila de espera de bolsas de IC");
            Console.WriteLine("6. Mostrar fila de espera de bolsas de Mestrado");
            Console.WriteLine("7. Pesquisar aluno na fila de espera de bolsas de IC");
            Console.WriteLine("8. Pesquisar aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("9. Sair");

        }
        static void Main(string[] args)
        {
            int opcaoMenu;
            string nomeAluno;
            bool contemNome;

            Fila filaBolsasIC = new Fila();
            Fila filaBolsasMestrado = new Fila();   

            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 9)
            {
                switch (opcaoMenu)
                {
                    case 1:

                        Console.WriteLine("Informe o nome do aluno:");
                        nomeAluno = Console.ReadLine();

                        filaBolsasIC.Inserir(nomeAluno);

                        break;
                    case 2:

                        Console.WriteLine("Informe o nome do aluno:");
                        nomeAluno = Console.ReadLine();

                        filaBolsasMestrado.Inserir(nomeAluno);

                        break;
                    case 3:

                        Console.WriteLine($"Aluno removido: {filaBolsasIC.Remover()}");

                        break;
                    case 4:

                        Console.WriteLine($"Aluno removido: {filaBolsasMestrado.Remover()}");

                        break;
                    case 5:

                        Console.WriteLine("Fila de Espera IC:");
                        filaBolsasIC.Mostrar();

                        break;
                    case 6:

                        Console.WriteLine("Fila de Espera Mestrado:");
                        filaBolsasMestrado.Mostrar();

                        break;
                    case 7:

                        Console.WriteLine("Informe o nome do aluno:");
                        nomeAluno = Console.ReadLine();

                        contemNome = filaBolsasIC.Pesquisar(nomeAluno);

                        if (contemNome)
                        {
                            Console.WriteLine("Aluno ja consta na fila de IC");
                        }
                        else
                        {
                            Console.WriteLine("Aluno nao consta na fila de IC");

                        }

                        break;
                    case 8:

                        Console.WriteLine("Informe o nome do aluno:");
                        nomeAluno = Console.ReadLine();

                        contemNome = filaBolsasMestrado.Pesquisar(nomeAluno);

                        if (contemNome)
                        {
                            Console.WriteLine("Aluno ja consta na fila de Mestrado");
                        }
                        else
                        {
                            Console.WriteLine("Aluno nao consta na fila de Mestrado");

                        }

                        break;
                  
                }

                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O programa sera encerrado");
            Console.ReadLine();
        }
    }
}