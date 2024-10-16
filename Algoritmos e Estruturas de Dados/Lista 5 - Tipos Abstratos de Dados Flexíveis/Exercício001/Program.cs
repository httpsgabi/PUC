using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequencia;
            char caracter, charPop;

            bool ehBemFormada = true;

            Pilha pilhaSequencia = new Pilha(); 

            Console.WriteLine("Informe a sequencia:");
            sequencia = Console.ReadLine();

            for (int i = 0; i < sequencia.Length; i++) { 
            
                caracter = sequencia[i];    

                if (caracter == '(' || caracter == '[')
                {
                    pilhaSequencia.Inserir(caracter);
                }
                else {
                    charPop = pilhaSequencia.Remover();

                    if ((caracter == ')' && charPop != '(') || (caracter == ']' && charPop != '['))
                    {
                        ehBemFormada = false;
                    }
                }

            }

            if (ehBemFormada == true && pilhaSequencia.EstaVazia() == true)
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