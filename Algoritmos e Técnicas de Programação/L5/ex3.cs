using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[200];
            int opcao;
            double menorNota = 101, maiorNota = 0, pesquisarNota, mediaNotas = 0.0, acimaDaMedia = 0 ;

            for (int i = 0; i < notas.Length; i++)
            {
                    Console.Write("\nDigite a nota " + (i + 1)+": ");
                    notas[i] = float.Parse(Console.ReadLine());

                    if (notas[i] < menorNota)
                    {
                        menorNota = notas[i];
                    }
                    if (notas[i] > maiorNota)
                    {
                        maiorNota = notas[i];
                    }
            }

            Console.Write("\nOpções\r\n1. Mostrar menor nota\r\n2. Mostrar maior nota\r\n3. Pesquisar nota\r\n4. Mostrar média das notas e quantidade de notas acima da média\r\n5. Sair\r\nDigite a opção: ");

            opcao = int.Parse(Console.ReadLine());

            while (opcao != 5) { 
                switch (opcao)
                {
                    case 1:
                        Console.Write("\nA menor nota é: " + menorNota);
                        break;
                    case 2:
                        Console.Write("\nA maior nota é: " + maiorNota);
                        break;
                    case 3:
                        Console.Write("\nDigite qual nota você quer pesquisar: ");
                        pesquisarNota = double.Parse(Console.ReadLine());

                        Console.Write("\nA nota pesquisada está nessas posições: ");
                        for (int j = 0; j < notas.Length; j++)
                        {
                            if (notas[j] == pesquisarNota)
                            {
                                Console.Write(j + " ");
                            }

                        }

                        break;
                    case 4:

                        for (int i = 0; i < notas.Length; i++)
                        {
                            mediaNotas += notas[i];
                        }   
                        
                        Console.WriteLine("A media das notas é: " + (mediaNotas/notas.Length));

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] > (mediaNotas / notas.Length))
                            {
                                acimaDaMedia++;
                            }
                        }

                        Console.WriteLine("As notas acima da media são: " + acimaDaMedia);

                        break;
                    default:
                        Console.WriteLine("Digite um valor entre 1 e 5");
                        break;

                }

                Console.Write("\nOpções\r\n1. Mostrar menor nota\r\n2. Mostrar maior nota\r\n3. Pesquisar nota\r\n4. Mostrar média das notas e quantidade de notas acima da média\r\n5. Sair\r\nDigite a opção: ");

                opcao = int.Parse(Console.ReadLine());

            }

            Console.ReadLine();
        }
    }
}
