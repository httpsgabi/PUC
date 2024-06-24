using System;
using System.IO;
using System.Text;

namespace Exercício003
{
    internal class Program
    {
        static void ImprimeNome(string[] nomePopular, int[] tempoCativeiro)
        {
            for (int i = 0; i < tempoCativeiro.Length; i++)
            {
                if (tempoCativeiro[i] >= 10 && tempoCativeiro[i] <= 16){
                    Console.WriteLine($"O nome popular do animal é: {nomePopular[i]}, e seu tempo máximo em cativeiro é: {tempoCativeiro[i]}");
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
            string linhaArquivo;
            string[] temp = new string[5];
            string[] nomePopular = new string[9];
            int[] tempoCativeiro= new int[9]; 
            int count = 0;

            try
            {
                StreamReader arquivo = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                linhaArquivo = arquivo.ReadLine();

                while (linhaArquivo != null)
                {
                    
                    temp = linhaArquivo.Split(';');

                    nomePopular[count] = temp[0];
                    tempoCativeiro[count] = int.Parse(temp[4]);

                    LimpaTemp(temp);
                    count++;

                    linhaArquivo = arquivo.ReadLine();
                }

                ImprimeNome(nomePopular, tempoCativeiro);
                arquivo.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex);
            }

            Console.ReadLine();
        }
    }
}
