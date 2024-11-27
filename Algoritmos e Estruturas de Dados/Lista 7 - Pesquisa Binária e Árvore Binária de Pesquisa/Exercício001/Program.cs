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
            string nomeAluno;

            Console.WriteLine("Informe N:");
            tamVet = int.Parse(Console.ReadLine());

            alunos = new Aluno[tamVet];

            for(int i = 0; i < alunos.Length; i++) {

                alunos[i].Nome = Console.ReadLine();
                alunos[i].Nota = int.Parse(Console.ReadLine());

            }

            do
            {
                Console.WriteLine("Informe o nome:");
                nomeAluno = Console.ReadLine();

                Console.WriteLine($"Nota: " + PesquisaBinaria(alunos, nomeAluno)); 

                Console.WriteLine("Continuar?[S ou N]");

            } while (continuar != 'N');

        }
    }

}