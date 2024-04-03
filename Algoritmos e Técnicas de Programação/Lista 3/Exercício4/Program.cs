using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite duas coordenadas X e Y que você saberá a qual quadrante eles pertecem, para sair digite 0 e 0: ");
            Console.Write("Coordenadas X: ");
            int coordenadaX = int.Parse(Console.ReadLine());
            Console.Write("Coordenadas Y: ");
            int coordenadaY = int.Parse(Console.ReadLine());

            while (coordenadaX != 0 && coordenadaY != 0)
            {
                

                if (coordenadaX > 0)
                {
                    if(coordenadaY > 0){
                        Console.WriteLine("Primeiro Quadrante (X > 0 e Y > 0)");
                    }
                    else
                    {
                        Console.WriteLine("Segundo Quadrante (X > 0 e Y < 0)");
                    }
                }
                else
                {
                    if (coordenadaY < 0)
                    {
                        Console.WriteLine("Terceiro Quadrante (X < 0 e Y < 0)");
                    }
                    else
                    {
                        Console.WriteLine("Quarto Quadrante (X < 0 e Y > 0)");
                    }
                }

                Console.WriteLine("\nDigite outros valores: ");
                Console.Write("Coordenadas X: ");
                coordenadaX = int.Parse(Console.ReadLine());
                Console.Write("Coordenadas Y: ");
                coordenadaY = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite outros valores: ");
                Console.Write("Coordenadas X: ");
                coordenadaX = int.Parse(Console.ReadLine());
                Console.Write("Coordenadas Y: ");
                coordenadaY = int.Parse(Console.ReadLine());Console.ReadLine();

        }
    }
}
