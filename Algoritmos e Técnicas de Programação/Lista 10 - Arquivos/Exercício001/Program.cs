using System;
using System.IO;
using System.Text;


namespace Exercício001
{
    
    internal class Program
    {
        static void ImprimeNomeCientifico(string[] nomesCientificos)
        {
            for (int i = 0; i < nomesCientificos.Length; i++)
            {
                Console.WriteLine($"Nome Cientifico do animal {i + 1}: {nomesCientificos[i]}");
            }
        }
        static void Main(string[] args)
        {
            string linha;
            string[] temp = new string[5];
            string[] nomesCientificos = new string[9];
            int count = 0;

            try 
            {
                StreamReader arquivo = new StreamReader("arquivo-01.txt", Encoding.UTF8);

                linha = arquivo.ReadLine();
                                        
                while (linha != null)
                {
                    temp = linha.Split(';');
                    nomesCientificos[count] = temp[1];

                    for (int i = 0;i < temp.Length; i++)
                    {
                        temp[i] = "";
                    }
                    count++;
                    linha = arquivo.ReadLine();

                }
                arquivo.Close();

                ImprimeNomeCientifico(nomesCientificos);

            }
            catch(Exception e) 
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
