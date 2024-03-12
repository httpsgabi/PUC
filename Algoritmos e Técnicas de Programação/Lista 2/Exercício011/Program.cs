using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra para saber se ela é vogal ou consoante: ");
            string letra = Console.ReadLine();
            
            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("É uma vogal");
                break;

                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine("É uma vogal");
                    break;  
                default:
                    Console.WriteLine("É uma consoante");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
