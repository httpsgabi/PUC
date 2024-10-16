using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Fila
    {
        private Celula primeiro, ultimo;
        public Fila()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void Inserir(string nome)
        {

            ultimo.Prox = new Celula(nome);
            ultimo = ultimo.Prox;
        }
        public string Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula tmp = primeiro;
            primeiro = primeiro.Prox;

            string nomeRemovido = primeiro.Elemento;

            tmp.Prox = null;
            tmp = null;

            return nomeRemovido;
        }
        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }

        public bool Pesquisar(string nome)
        {
            bool consta = false;

            for (Celula i = primeiro.Prox; i != null && consta == false; i = i.Prox)
            {
                if (nome == i.Elemento)
                {
                    consta = true;
                }
            }

            return consta;
        }
    }
}
