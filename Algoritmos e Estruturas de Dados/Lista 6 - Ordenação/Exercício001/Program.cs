using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Selecao(int[] array, int n)
        {
            for (int i = 0; i < (n - 1); i++)
            {
                int menor = i;
                for (int j = (i + 1); j < n; j++)
                {
                    if (array[menor] > array[j])
                    {
                        menor = j;
                    }
                }
                int temp = array[menor];
                array[menor] = array[i];
                array[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //Colocar aqui o trecho de código cujo tempo de execução deseja-se calcular

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours,
            ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Tempo " + elapsedTime);
        }
    }
}
