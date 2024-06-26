﻿using System;
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
            int tamVetor = 0, cont = 0;
            bool ehPalindromo = true;

            Console.WriteLine("Digite o tamanho que terá um número e seus dígitos para verificar se ele é palíndromo: ");

            Console.Write("Tamanho: ");
            tamVetor = int.Parse(Console.ReadLine());

            int[] palindromo = new int[tamVetor];

            Console.Write("Dígitos: ");
            for (int i = 0; i < palindromo.Length; i++)
            {
                palindromo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < palindromo.Length; i++)
            {

                if (palindromo[i] != palindromo[tamVetor - 1])
                {
                    ehPalindromo = false;
                }

                tamVetor--;
            }

            Console.WriteLine(ehPalindromo ? "O número é palíndromo" : "O número não é palíndromo");

            Console.ReadLine();
        }
    }
}
