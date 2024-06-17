using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006_New_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            Console.WriteLine("Digite a frase que deseja criptografar: ");
            frase = Console.ReadLine();

            frase = frase.Replace("a", "*");
            frase = frase.Replace("e", "*");
            frase = frase.Replace("i", "*");
            frase = frase.Replace("o", "*");
            frase = frase.Replace("u", "*");

            Console.WriteLine($"A frase criptografada é: {frase}");

            Console.ReadLine();
        }
    }
}
