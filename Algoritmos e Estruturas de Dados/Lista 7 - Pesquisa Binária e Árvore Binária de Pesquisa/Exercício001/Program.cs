using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    
    internal class Program
    {
        static int PesquisaBinaria(Aluno[] vet, string nomeAluno)
        {
            int notaAluno = 0, direita = vet.Length - 1, esquerda = 0, meio;
            
            while (esquerda <= direita)
            {
                meio = (esquerda + direita) / 2;

                if (nomeAluno.CompareTo(vet[meio].Nome) == 0)
                {
                    notaAluno = vet[meio].Nota;
                    esquerda = vet.Length - 1;
                }
                else if (nomeAluno.CompareTo(vet[meio].Nome) != 0)
                {
                    esquerda = meio + 1;
                }
                else
                {
                    direita = meio - 1;
                }
            }

            return notaAluno;
        }
        static void Main(string[] args)
        {
            Aluno[] alunos;
            int tamVet;
            char continuar = 'S';
            string nomeAluno, nomeENota;

            string[] nomeENotas = new string[2]; 

            Console.WriteLine("Informe N:");
            tamVet = int.Parse(Console.ReadLine());

            alunos = new Aluno[tamVet];

            for(int i = 0; i < alunos.Length; i++) {

                alunos[i] = new Aluno();
                nomeENota = Console.ReadLine();
                nomeENotas = nomeENota.Split(',');
                
                alunos[i].Nome = nomeENotas[0];
                alunos[i].Nota =int.Parse(nomeENotas[1]);

            }

            do
            {
                Console.WriteLine("Informe o nome:");
                nomeAluno = Console.ReadLine();

                if (PesquisaBinaria(alunos, nomeAluno) == 0)
                {
                    Console.WriteLine("Aluno nao consta na base");
                }
                else
                {
                    Console.WriteLine("Nota: ");

                }

                Console.WriteLine("Continuar?[S ou N]");
                continuar = char.Parse(Console.ReadLine()); 

            } while (continuar != 'N');

        }
    }


}
internal class Aluno
{
    private string nome;
    private int nota;

    public Aluno()
    {
        this.nome = "";
        this.nota = 0;
    }

    public string Nome
    {

        get { return nome; }
        set { nome = value; }
    }

    public int Nota
    {

        get { return nota; }
        set { nota = value; }
    }
}