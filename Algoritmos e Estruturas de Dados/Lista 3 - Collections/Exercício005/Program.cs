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
            string frase, palavra = null;

            Console.WriteLine("Digite a Frase:");
            frase = Console.ReadLine();

            Dictionary<string, int> dicionario = new Dictionary<string, int>();

            frase = frase.ToLower();

            for (int i = 0; i <= frase.Length; i++)
            {
                if (i == frase.Length || frase[i] == ' ')
                {
                    if (dicionario.ContainsKey(palavra))
                    {
                        dicionario[palavra]++;
                    }
                    else
                    {
                        dicionario.Add(palavra, 1);
                    }

                    palavra = string.Empty;
                }
                else
                {
                    palavra += frase[i];
                }
            }

            foreach (KeyValuePair<string, int> palavras in dicionario)
                Console.WriteLine($"{palavras.Key}: {palavras.Value} ocorrencia(s).");

            Console.ReadLine();
        }
    }
}
