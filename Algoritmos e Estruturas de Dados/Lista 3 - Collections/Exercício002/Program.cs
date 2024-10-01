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
            int numConvertido;
            double num1, num2, resultado;
            char caracter;
            string expressao;

            Stack<double> pilhaExpressao = new Stack<double>();

            Console.WriteLine("Informe uma expressao:");
            expressao = Console.ReadLine();

            for (int i = 0; i < expressao.Length; i++)
            {
                caracter = expressao[i];

                if (caracter == '+')
                {
                    num1 = pilhaExpressao.Pop();
                    num2 = pilhaExpressao.Pop();

                    resultado = num2 + num1;

                    pilhaExpressao.Push(resultado);
                }
                else if (caracter == '-')
                {
                    num1 = pilhaExpressao.Pop();
                    num2 = pilhaExpressao.Pop();

                    resultado = num2 - num1;

                    pilhaExpressao.Push(resultado);
                }
                else if (caracter == '/')
                {
                    num1 = pilhaExpressao.Pop();
                    num2 = pilhaExpressao.Pop();

                    resultado = num2 / num1;

                    pilhaExpressao.Push(resultado);
                }
                else if (caracter == '*')
                {
                    num1 = pilhaExpressao.Pop();
                    num2 = pilhaExpressao.Pop();

                    resultado = num2 * num1;

                    pilhaExpressao.Push(resultado);
                }
                else{
                    numConvertido = (int)Char.GetNumericValue(caracter);
                    pilhaExpressao.Push(numConvertido);
                }

            }
            Console.WriteLine("Resultado: " + pilhaExpressao.Peek());

            Console.ReadLine();
        }
    }
}