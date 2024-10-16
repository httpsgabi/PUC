using Exercício002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resto;

            Pilha pilhaOctal = new Pilha();

            Console.WriteLine("Informe um numero:");
            numero = int.Parse(Console.ReadLine()); 

            while (numero % 8 != 0)
            {
                resto = numero % 8;

                pilhaOctal.Inserir(resto);

                numero = numero / 8;
            }

            Console.Write($"Octal: ");
            pilhaOctal.Mostrar();
            
            Console.ReadLine();
        }
    }

}