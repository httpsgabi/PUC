using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase, seletor;
            int posicao = 0, count = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Agora digite uma string que queira pesquisar: ");
            seletor = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                posicao = frase.IndexOf(seletor);

                if (posicao != -1)
                {
                   count++;
                   frase = frase.Remove(posicao, seletor.Length).Insert(posicao, "*");
                }
            }

            Console.WriteLine($"A quantidade de vezes que '{seletor}' aparece é de: {count}");

            Console.ReadLine();
        }
    }
}
