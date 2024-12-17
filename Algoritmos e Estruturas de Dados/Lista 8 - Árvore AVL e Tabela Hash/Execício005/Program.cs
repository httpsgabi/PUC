using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execício005
{
    using System;

    class Estudante
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        public Estudante(int matricula, string nome, string curso)
        {
            Matricula = matricula;
            Nome = nome;
            Curso = curso;
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}\nNome: {Nome}\nCurso: {Curso}";
        }
    }

    class No
    {
        public Estudante Estudante { get; set; }
        public No Proximo { get; set; }

        public No(Estudante estudante)
        {
            Estudante = estudante;
            Proximo = null;
        }
    }

    class Lista
    {
        private No cabeca;

        public Lista()
        {
            cabeca = null;
        }

        public void Inserir(Estudante estudante)
        {
            No novoNo = new No(estudante);
            novoNo.Proximo = cabeca;
            cabeca = novoNo;
        }

        public bool Remover(int matricula)
        {
            No anterior = null;
            No atual = cabeca;
            while (atual != null)
            {
                if (atual.Estudante.Matricula == matricula)
                {
                    if (anterior == null)
                    {
                        cabeca = atual.Proximo;
                    }
                    else
                    {
                        anterior.Proximo = atual.Proximo;
                    }
                    return true;
                }
                anterior = atual;
                atual = atual.Proximo;
            }
            return false;
        }

        public Estudante Pesquisar(int matricula)
        {
            No atual = cabeca;
            while (atual != null)
            {
                if (atual.Estudante.Matricula == matricula)
                {
                    return atual.Estudante;
                }
                atual = atual.Proximo;
            }
            return null;
        }
    }

    class TabelaHash
    {
        private Lista[] tabela;
        private const int TAMANHO = 101;

        public TabelaHash()
        {
            tabela = new Lista[TAMANHO];
            for (int i = 0; i < TAMANHO; i++)
            {
                tabela[i] = new Lista();
            }
        }

        private int Hash(int matricula)
        {
            return matricula % TAMANHO;
        }

        public void Inserir(Estudante estudante)
        {
            int indice = Hash(estudante.Matricula);
            tabela[indice].Inserir(estudante);
        }

        public bool Remover(int matricula)
        {
            int indice = Hash(matricula);
            return tabela[indice].Remover(matricula);
        }

        public Estudante Pesquisar(int matricula)
        {
            int indice = Hash(matricula);
            return tabela[indice].Pesquisar(matricula);
        }
    }

    class Programa
    {
        static void ExibirMenu()
        {
            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("1 - Inserir um estudante");
            Console.WriteLine("2 - Remover um estudante");
            Console.WriteLine("3 - Pesquisar um estudante");
            Console.WriteLine("4 - Sair");
        }

        static void Main(string[] args)
        {
            TabelaHash tabela = new TabelaHash();
            int opcao;

            ExibirMenu();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {
               
                if (opcao == 1)
                {
                    Console.Write("Digite a matrícula do estudante: ");
                    int matricula = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do estudante: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o curso do estudante: ");
                    string curso = Console.ReadLine();

                    Estudante estudante = new Estudante(matricula, nome, curso);
                    tabela.Inserir(estudante);
                    Console.WriteLine("Estudante inserido com sucesso!");
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite a matrícula do estudante a ser removido: ");
                    int matricula = int.Parse(Console.ReadLine());
                    if (tabela.Remover(matricula))
                    {
                        Console.WriteLine("Estudante removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Estudante não encontrado!");
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite a matrícula do estudante a ser pesquisado: ");
                    int matricula = int.Parse(Console.ReadLine());
                    Estudante estudante = tabela.Pesquisar(matricula);
                    if (estudante != null)
                    {
                        Console.WriteLine(estudante);
                    }
                    else
                    {
                        Console.WriteLine("Estudante não cadastrado.");
                    }

                    ExibirMenu();
                    Console.Write("Escolha uma opção: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }
    }

}
