using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Fila
    {
        private string[] fila;
        private int primeiro, ultimo;

        public Fila(int tamanho)
        {
            fila = new string [tamanho + 1];
            primeiro = ultimo = 0;
        }

        public int ObterTamanho()
        {
            return ultimo - primeiro; 
        }

        public string ObterPrimeiro()
        {
            string primeiroFila = fila[primeiro];
            return primeiroFila;
        }

        public void Inserir(string aviao) {

            if ((ultimo + 1) % fila.Length == primeiro) {
                throw new Exception("Erro, lista cheia");
            }

            fila[ultimo] = aviao;
            ultimo = (ultimo + 1) % fila.Length;

        }

        public string Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro, lista vazia");
            }

            string resposta = fila[primeiro];
            primeiro = (primeiro + 1) % fila.Length;
            return resposta;
        }

        public void Mostrar()
        {
            int i = primeiro;

            while (i != ultimo)
            {
                Console.WriteLine(fila[i]);
                i = (i + 1) % fila.Length;
            }
        
        }
    }
}
