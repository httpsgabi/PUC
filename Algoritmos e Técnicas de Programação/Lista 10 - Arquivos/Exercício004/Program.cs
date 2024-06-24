using System;
using System.IO;
using System.Text;

namespace Exercício004
{
    internal class Program
    {
        static void ExibePesos(int[] pesosAnimais, int[,] maiorEmenorPeso, string[] nomesAnimais)
        {
            for (int linha = 0; linha < maiorEmenorPeso.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < maiorEmenorPeso.GetLength(1); coluna++)
                {
                    if(pesosAnimais[linha] > maiorEmenorPeso[linha,coluna] && pesosAnimais[linha] < maiorEmenorPeso[coluna, linha])
                    {
                        Console.WriteLine($"O animal: {nomesAnimais[coluna]}, está nessa faixa de peso: {maiorEmenorPeso[coluna, linha]}");
                    }
                }
            }
        }

        static void LimpaTemp(string[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = "";
            }
        }

        static void Main(string[] args)
        {
            string linhaArq1, linhaArq2;
            int count = 0;


            int[] pesosAnimais = new int[9];
            string[] nomesAnimais = new string[9];
            string[] temp = new string[5];
            int[,] maiorEmenorPeso = new int[2,6]; 

            try
            {
                StreamReader arquivo1 = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                StreamReader arquivo2 = new StreamReader("arquivo-02.txt", Encoding.UTF8);

                linhaArq1 = arquivo1.ReadLine();
                linhaArq2 = arquivo2.ReadLine();

                while (linhaArq1 != null)
                {
                    temp = linhaArq1.Split(';');
                    pesosAnimais[count] = int.Parse(temp[3]);
                    nomesAnimais[count] = temp[0];

                    LimpaTemp(temp);

                    temp = linhaArq2.Split(';');
                    maiorEmenorPeso[0, count] = int.Parse(temp[0]);
                    maiorEmenorPeso[1, count] = int.Parse(temp[1]);

                    LimpaTemp(temp);

                    linhaArq1 = arquivo1.ReadLine();
                    linhaArq2 = arquivo2.ReadLine();
                    
                    count++;
                }
                ExibePesos(pesosAnimais, maiorEmenorPeso, nomesAnimais);

                arquivo1.Close();
                arquivo2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }

            Console.ReadLine();
        }
    }
}
