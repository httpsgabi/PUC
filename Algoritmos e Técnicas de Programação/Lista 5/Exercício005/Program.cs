using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notasATP = new double[6];
            int i = 0, notasAcimaDaMedia = 0;
            double mediaAlunos = 0.0 ;


            Console.WriteLine("Digite as notas dos alunos. Digite um valor negativo para encerrar.");

            while (i < notasATP.Length)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0)
                    break;

                notasATP[i] = nota;
                mediaAlunos += nota;
                i++;
            }

            if (i == 0)
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
            }
            else
            {
                mediaAlunos /= i;

                Console.WriteLine("\nNotas de todos os alunos:");
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("Nota " + (j + 1) + ": " + notasATP[j]);
                }


                Console.WriteLine("\nNotas acima da média (" + mediaAlunos + "):");
                for (int j = 0; j < i; j++)
                {
                    if (notasATP[j] > mediaAlunos)
                    {
                        Console.WriteLine("Nota " + (j + 1) + ": " + notasATP[j]);
                        notasAcimaDaMedia++;
                    }
                }

                Console.WriteLine("\nA média dos alunos é: " + mediaAlunos);
                Console.WriteLine("A quantidade de notas acima da média é: " + notasAcimaDaMedia);
            }

            Console.ReadLine();

        }
    }
}


namespace Exercicio005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            // Leitura das notas dos alunos
            

            // Verifica se foi digitado pelo menos uma nota
            
        }
    }
}
