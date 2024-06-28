using System;
using System.IO;
using System.Text;

namespace Exercício004
{
    internal class Program
    {
        static void ExibePesos(int[] pesosAnimais, int[,] maiorEmenorPeso, string[] nomesAnimais)
        {
            for (int i = 0; i < pesosAnimais.Length; i++)
            {
                for (int j = 0; j < maiorEmenorPeso.GetLength(0); j++)
                {
                    int intervalo1 = maiorEmenorPeso[j, 0];
                    int intervalo2 = maiorEmenorPeso[j, 1];

                    if (pesosAnimais[i] >= intervalo1 && pesosAnimais[i] <= intervalo2)
                    {
                        Console.WriteLine($"O animal {nomesAnimais[i]}, possui peso {pesosAnimais[i]}, e está presente no intervalo de {intervalo1} até {intervalo2}");                        
                    }
                }
                
            }
        }

        static void Main(string[] args)
        {
            string linhaArq1, linhaArq2;
            int count = 0;

            int[] pesosAnimais = new int[9];
            string[] nomesAnimais = new string[9];
            int[,] maiorEmenorPeso = new int[6, 2]; 

            try
            {
                StreamReader arquivo1 = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                StreamReader arquivo2 = new StreamReader("arquivo-02.txt", Encoding.UTF8);
                {
                    linhaArq1 = arquivo1.ReadLine();
                    linhaArq2 = arquivo2.ReadLine();

                    while (linhaArq1 != null && linhaArq2 != null)
                    {
                        if (count < 6)
                        {
                            var temp2 = linhaArq2.Split(';');
                            maiorEmenorPeso[count, 0] = int.Parse(temp2[0]);
                            maiorEmenorPeso[count, 1] = int.Parse(temp2[1]);
                            linhaArq2 = arquivo2.ReadLine();
                        }

                        var temp1 = linhaArq1.Split(';');
                        pesosAnimais[count] = int.Parse(temp1[3]);
                        nomesAnimais[count] = temp1[0];
                        linhaArq1 = arquivo1.ReadLine();

                        count++;
                    }
                }

                ExibePesos(pesosAnimais, maiorEmenorPeso, nomesAnimais);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
