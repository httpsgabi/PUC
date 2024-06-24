using System;
using System.Text;
using System.IO;

namespace Exercício002
{
    internal class Program
    {
        static void ImprimeInfoPesos(int[] pesos)
        {
            int maiorPeso = 0, menorPeso = 1000;
            float mediaPesos = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                if (pesos[i] > maiorPeso)
                {
                    maiorPeso = pesos[i];
                }
                else if (pesos[i] < menorPeso)
                {
                    menorPeso = pesos[i];
                }
                mediaPesos += pesos[i];
            }

            Console.WriteLine($"O maior peso é: {maiorPeso}, e o menor peso é {menorPeso}");
        }
        static void Main(string[] args)
        {
            string linha;
            string[] temp = new string[5];
            int[] pesos = new int[9];
            int count = 0;

            try
            {
                StreamReader arquivo = new StreamReader("arquivo-01.txt", Encoding.UTF8);

                linha = arquivo.ReadLine();

                while (linha != null)
                {
                    temp = linha.Split(';');
                    pesos[count] = int.Parse(temp[3]);

                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = "";
                    }
                    count++;
                    linha = arquivo.ReadLine();
                }
                arquivo.Close();

                ImprimeInfoPesos(pesos);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
