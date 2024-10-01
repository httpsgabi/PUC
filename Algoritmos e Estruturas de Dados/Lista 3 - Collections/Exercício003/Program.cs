using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            Stack<char> pilhaSequencia = new Stack<char>(); 

            Console.WriteLine("Informe a sequencia:");
            sequencia = Console.ReadLine();

            for (int i = 0; i < sequencia.Length; i++) {               
                caracter = sequencia[i];

                if (caracter == '(' || caracter == '[')
                {
                    pilhaSequencia.Push(caracter);
                }
                else if (caracter == ')' || caracter == ']')
                {
                    caracterPop = pilhaSequencia.Pop();

                    if ((caracter == ')' && caracterPop != '(') || (caracter == ']' && caracterPop != '['))
                    {
                        ehBemFormada = false;
                    }
                }            
            }
            if (ehBemFormada == true && pilhaSequencia.Count == 0)
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
