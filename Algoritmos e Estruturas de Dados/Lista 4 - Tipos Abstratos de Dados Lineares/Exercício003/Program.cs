using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sequencia;
            char caracter, caracterPop;
            bool ehBemFormada = true;

            Pilha pilhaSequencia = new Pilha(100);

            Console.WriteLine("Informe a sequencia:");
            sequencia = Console.ReadLine();

            for (int i = 0; i < sequencia.Length; i++)
            {
                caracter = sequencia[i];

                if (caracter == '(' || caracter == '[')
                {
                    pilhaSequencia.Empilhar(caracter);
                }
                else if (caracter == ')' || caracter == ']')
                {
                    caracterPop = pilhaSequencia.Desempilhar();

                    if ((caracter == ')' && caracterPop != '(') || (caracter == ']' && caracterPop != '['))
                    {
                        ehBemFormada = false;
                    }
                }
            }
            if (ehBemFormada == true && pilhaSequencia.ObterTamanho() == 0)
            {
                Console.WriteLine("Sequencia bem formada!");
            }
            else
            {
                Console.WriteLine("Sequencia mal formada!");
            }

            Console.ReadLine();



        }
    }

}