using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{

    internal class Pilha
    {
        private char[] pilha;
        private int count;

        public Pilha(int tamanho)
        {
            pilha = new char[100];
            count = 0;
        }

        public void Empilhar(char caracter)
        {
            if (count >= pilha.Length)
            {
                throw new Exception("Erro");
            }

            pilha[count] = caracter;
            count++;
        }

        public char Desempilhar()
        {
            if (count == 0)
            {
                throw new Exception("Erro");
            }

            char caracter = pilha[count - 1];
            count--;

            return caracter;
        }
        public int ObterTamanho()
        {
            int tamanho = count;
            return tamanho;
        }
    }
}
