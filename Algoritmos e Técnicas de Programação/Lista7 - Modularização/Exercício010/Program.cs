using System;
using System.Linq;

class Program
{ 
    static int[] LerVetor(string disciplina)
    {
        int[] vetor = new int[10];
        Console.WriteLine($"Digite os números de matrícula dos alunos matriculados em {disciplina}:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Matrícula {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        return vetor;
    }

    static int[] CalcularIntersecao(int[] vetor1, int[] vetor2)
    {
        return vetor1.Intersect(vetor2).ToArray();
    }
    static void Main()
    {
        int[] matriculasAlgoritmos = LerVetor("Algoritmos e Técnicas de Programação");
        int[] matriculasDIW = LerVetor("Desenvolvimento de Interfaces Web");

        int[] intersecao = CalcularIntersecao(matriculasAlgoritmos, matriculasDIW);

        if (intersecao.Length > 0)
        {
            Console.WriteLine("Alunos matriculados simultaneamente nas duas disciplinas:");
            foreach (int matricula in intersecao)
            {
                Console.WriteLine(matricula);
            }
        }
        else
        {
            Console.WriteLine("Não existem alunos matriculados simultaneamente nas duas disciplinas.");
        }
    }
}
