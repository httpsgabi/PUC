using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static int Mdc(int num1, int num2)
        {
            int mdc;

            if (num1 == num2)
            {
                mdc = num1;
            }
            else
            {
                if (num1 > num2) {
                    mdc = Mdc(num1 - num2, num2);
                }
                else{
                    mdc = Mdc(num2, num1);
                }
               
            }            

            return mdc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Mdc(10, 4));
            Console.ReadLine();
        }
        
    }
}
