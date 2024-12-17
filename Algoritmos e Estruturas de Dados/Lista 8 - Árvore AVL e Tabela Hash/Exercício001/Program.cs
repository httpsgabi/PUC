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
                AVL avl = new AVL();
                bool sair = false;

                while (!sair)
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine("1 - Cadastrar um paciente");
                    Console.WriteLine("2 - Remover um paciente");
                    Console.WriteLine("3 - Pesquisar um paciente");
                    Console.WriteLine("4 - Mostrar nomes dos pacientes (caminhamento central)");
                    Console.WriteLine("5 - Mostrar CPFs dos pacientes (caminhamento pós-ordem)");
                    Console.WriteLine("6 - Mostrar e-mails dos pacientes (caminhamento pré-ordem)");
                    Console.WriteLine("7 - Sair");
                    Console.Write("Opção: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe o CPF: ");
                            int cpf = int.Parse(Console.ReadLine());
                            Console.Write("Informe o nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe o email: ");
                            string email = Console.ReadLine();
                            Console.Write("Informe o telefone: ");
                            string telefone = Console.ReadLine();

                            Paciente paciente = new Paciente(cpf, nome, email, telefone);
                            avl.Inserir(paciente);
                            Console.WriteLine("Paciente cadastrado com sucesso!");
                            break;

                        case 2:
                            Console.Write("Informe o CPF do paciente a ser removido: ");
                            int cpfRemover = int.Parse(Console.ReadLine());
                            avl.Remover(cpfRemover);
                            Console.WriteLine("Paciente removido com sucesso!");
                            break;

                        case 3:
                            Console.Write("Informe o CPF para pesquisa: ");
                            int cpfPesquisa = int.Parse(Console.ReadLine());
                            Paciente pacientePesquisado = avl.Pesquisar(cpfPesquisa);
                            if (pacientePesquisado != null)
                            {
                                Console.WriteLine(pacientePesquisado);
                            }
                            else
                            {
                                Console.WriteLine("Paciente não cadastrado.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Nomes dos pacientes (Caminhamento Central):");
                            avl.CaminharCentral();
                            break;

                        case 5:
                            Console.WriteLine("CPFs dos pacientes (Caminhamento Pós-ordem):");
                            avl.CaminharPos();
                            break;

                        case 6:
                            Console.WriteLine("E-mails dos pacientes (Caminhamento Pré-ordem):");
                            avl.CaminharPre();
                            break;

                        case 7:
                            sair = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }

class Paciente
{
    public int Cpf { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Paciente(int cpf, string nome, string email, string telefone)
    {
        Cpf = cpf;
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"CPF: {Cpf}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}";
    }
}

class No
{
    public Paciente Paciente { get; set; }
    public No Esq { get; set; }
    public No Dir { get; set; }
    public int Nivel { get; set; }

    public No(Paciente paciente)
    {
        Paciente = paciente;
        Esq = null;
        Dir = null;
        Nivel = 1;
    }

    public static int GetNivel(No no)
    {
        return (no == null) ? 0 : no.Nivel;
    }

    public void SetNivel()
    {
        this.Nivel = 1 + Math.Max(GetNivel(Esq), GetNivel(Dir));
    }
}

class AVL
{
    private No raiz;

    public AVL()
    {
        raiz = null;
    }

    public void Inserir(Paciente paciente)
    {
        raiz = Inserir(paciente, raiz);
    }

    private No Inserir(Paciente paciente, No no)
    {
        if (no == null)
        {
            no = new No(paciente);
        }
        else if (paciente.Cpf < no.Paciente.Cpf)
        {
            no.Esq = Inserir(paciente, no.Esq);
        }
        else if (paciente.Cpf > no.Paciente.Cpf)
        {
            no.Dir = Inserir(paciente, no.Dir);
        }
        else
        {
            throw new Exception("Paciente com o mesmo CPF já cadastrado.");
        }

        return Balancear(no);
    }

    public void Remover(int cpf)
    {
        raiz = Remover(cpf, raiz);
    }

    private No Remover(int cpf, No no)
    {
        if (no == null)
        {
            throw new Exception("Paciente não encontrado.");
        }

        if (cpf < no.Paciente.Cpf)
        {
            no.Esq = Remover(cpf, no.Esq);
        }
        else if (cpf > no.Paciente.Cpf)
        {
            no.Dir = Remover(cpf, no.Dir);
        }
        else
        {
            if (no.Dir == null)
            {
                no = no.Esq;
            }
            else if (no.Esq == null)
            {
                no = no.Dir;
            }
            else
            {
                no.Esq = MaiorEsq(no, no.Esq);
            }
        }
        return Balancear(no);
    }

    private No MaiorEsq(No no, No j)
    {
        if (j.Dir == null)
        {
            no.Paciente = j.Paciente;
            j = j.Esq;
        }
        else
        {
            j.Dir = MaiorEsq(no, j.Dir);
        }
        return Balancear(j);
    }

    private No Balancear(No no)
    {
        if (no != null)
        {
            int fator = No.GetNivel(no.Dir) - No.GetNivel(no.Esq);

            if (fator == 0 || fator == 1 || fator == -1)
            {
                no.SetNivel();
            }
            else if (fator == 2)
            {
                int fatorFilhoDir = No.GetNivel(no.Dir.Dir) - No.GetNivel(no.Dir.Esq);
                if (fatorFilhoDir == -1)
                {
                    no.Dir = RotacionarDir(no.Dir);
                }
                no = RotacionarEsq(no);
            }
            else if (fator == -2)
            {
                int fatorFilhoEsq = No.GetNivel(no.Esq.Dir) - No.GetNivel(no.Esq.Esq);
                if (fatorFilhoEsq == 1)
                {
                    no.Esq = RotacionarEsq(no.Esq);
                }
                no = RotacionarDir(no);
            }
        }
        return no;
    }

    private No RotacionarDir(No no)
    {
        No noEsq = no.Esq;
        No noEsqDir = noEsq.Dir;
        noEsq.Dir = no;
        no.Esq = noEsqDir;
        no.SetNivel();
        noEsq.SetNivel();
        return noEsq;
    }

    private No RotacionarEsq(No no)
    {
        No noDir = no.Dir;
        No noDirEsq = noDir.Esq;
        noDir.Esq = no;
        no.Dir = noDirEsq;
        no.SetNivel();
        noDir.SetNivel();
        return noDir;
    }

    public Paciente Pesquisar(int cpf)
    {
        return Pesquisar(cpf, raiz);
    }

    private Paciente Pesquisar(int cpf, No no)
    {
        if (no == null)
            return null;

        if (cpf == no.Paciente.Cpf)
            return no.Paciente;

        if (cpf < no.Paciente.Cpf)
            return Pesquisar(cpf, no.Esq);

        return Pesquisar(cpf, no.Dir);
    }

    public void CaminharCentral()
    {
        CaminharCentral(raiz);
    }

    private void CaminharCentral(No no)
    {
        if (no != null)
        {
            CaminharCentral(no.Esq);
            Console.WriteLine(no.Paciente.Nome);
            CaminharCentral(no.Dir);
        }
    }

    public void CaminharPos()
    {
        CaminharPos(raiz);
    }

    private void CaminharPos(No no)
    {
        if (no != null)
        {
            CaminharPos(no.Esq);
            CaminharPos(no.Dir);
            Console.WriteLine(no.Paciente.Cpf);
        }
    }

    public void CaminharPre()
    {
        CaminharPre(raiz);
    }

    private void CaminharPre(No no)
    {
        if (no != null)
        {
            Console.WriteLine(no.Paciente.Email);
            CaminharPre(no.Esq);
            CaminharPre(no.Dir);
        }
    }
}
