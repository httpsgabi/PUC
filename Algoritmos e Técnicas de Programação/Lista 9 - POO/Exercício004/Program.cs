using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void PreencheVetor(float[] notas)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) {
                notas[i] = rnd.Next(0, 10);
            }
        }
        static void Main(string[] args)
        {
            float[] notas1 = new float[10];
            float[] notas2 = new float[10];

            PreencheVetor(notas1);
            PreencheVetor(notas2);

            Aluno aluno1 = new Aluno(2021951329, notas1);
            aluno1.ImprimeInformacoes();

            
            Aluno aluno2 = new Aluno(2021951240, notas2);
            aluno2.ImprimeInformacoes();

            Console.ReadLine();
        }
    }
}
