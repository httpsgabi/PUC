using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String verbo;
            char resposta = 's';
            bool terminaAR;
            int lastIndexOf = 0;

            string[] sujeitos = { "eu", "tu", "ele", "nós", "vós", "eles" };
            string[] presente = { "o", "as", "a", "amos", "ais", "am" };
            string[] preteritoPerfeito = { "ei", "aste", "ou", "amos", "astes", "aram" };
            string[] futuroDoPresente = { "arei", "arás", "aremos", "areis", "arão" };

            Console.WriteLine("Digite um verbo com a terminação 'AR' para imprimir a sua conjugação verbal: ");
            verbo = Console.ReadLine();
            lastIndexOf = verbo.LastIndexOf('r');
            terminaAR = verbo.EndsWith("ar");

            if (terminaAR)
            {
                while (resposta != 'n' || resposta != 'N')
                {

                    verbo = verbo.Remove(lastIndexOf);
                    verbo = verbo.Remove(lastIndexOf - 1);
                    Console.WriteLine("Presente: ");
                    for (int i = 0; i < presente.Length; i++)
                    {
                        Console.WriteLine($"{sujeitos[i]} {verbo}{presente[i]}");
                    }
                    Console.WriteLine("\nPretérito Perfeito:");
                    for (int i = 0; i< preteritoPerfeito.Length; i++)
                    {
                        Console.WriteLine($"{sujeitos[i]} {verbo}{preteritoPerfeito[i]}");
                    }
                    Console.WriteLine("\nFuturo do Presente:");
                    for (int i = 0; i < futuroDoPresente.Length; i++)
                    {
                        Console.WriteLine($"{sujeitos[i]} {verbo}{futuroDoPresente[i]}");
                    }

                        Console.WriteLine("\nDeseja informar um novo verbo? ");
                        resposta = char.Parse(Console.ReadLine());

                        if (resposta == 's' || resposta == 'S')
                        {
                            Console.WriteLine("Digite um verbo com a terminação 'AR' para imprimir a sua conjugação verbal: ");
                            verbo = Console.ReadLine();

                            lastIndexOf = verbo.LastIndexOf('r');
                            terminaAR = verbo.EndsWith("ar");
                        }
                    }
            } else
            {
                Console.WriteLine("Erro, verbo não possui a terminação 'AR'");
            }

            Console.ReadLine();
        }
    }
}
