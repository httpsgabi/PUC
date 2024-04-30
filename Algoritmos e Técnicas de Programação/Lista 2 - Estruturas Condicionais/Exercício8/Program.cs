using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 1 e 7 para saber o dia da semana que ele corresponde: ");
            int diaSemana = int.Parse(Console.ReadLine());  

            if (diaSemana >= 1 && diaSemana <=7 ) {
                switch (diaSemana)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda");
                        break;
                    case 3:
                        Console.WriteLine("Terça");
                        break;
                    case 4:
                        Console.WriteLine("Quarta");
                        break;
                    case 5:
                        Console.WriteLine("Quinta");
                        break;
                    case 6:
                        Console.WriteLine("Sexta");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Dia inválido");
            }

            Console.ReadLine();
        }
    }
}
