using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class ListaSimples
    {
        private Celula primeiro, ultimo;
        public ListaSimples()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public void InserirInicio(double tempo) {

            Celula tmp = new Celula(tempo);
            tmp.Prox = primeiro.Prox;
            primeiro.Prox = tmp;

            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }

            tmp = null;
        }
        public void InserirFim(double tempo) {

            ultimo.Prox = new Celula(tempo);
            ultimo = ultimo.Prox;
        }
        public void Inserir(double tempo, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                InserirInicio(tempo);
            }
            else if (pos == tamanho)
            {
                InserirFim(tempo);
            }
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                Celula tmp = new Celula(tempo);
                tmp.Prox = i.Prox;
                i.Prox = tmp;
                tmp = i = null;
            }
        }
        
        public double RemoverInicio() {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula tmp = primeiro;
            primeiro = primeiro.Prox;

            double tempoRemovido = primeiro.Elemento;

            tmp.Prox = null;
            tmp = null;

            return tempoRemovido;
        }

        public double RemoverFim()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula i;
            for (i = primeiro; i.Prox != ultimo; i = i.Prox) ;

            double elemento = ultimo.Elemento;

            ultimo = i;
            i = ultimo.Prox = null;

            return elemento;
        }
        public double RemoverPos(int pos) {

            int tamanho = Tamanho();
            double elemento;


            if (primeiro == ultimo || pos < 0 || pos >= tamanho)
            {
                throw new Exception("Erro!");
            }

            else if (pos == 0)
            {
                elemento = RemoverInicio();
            }

            else if (pos == tamanho - 1)
            {
                elemento = RemoverFim();
            }

            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                Celula tmp = i.Prox;
                elemento = tmp.Elemento; i.Prox = tmp.Prox;
                tmp.Prox = null; i = tmp = null;
            }
            return elemento;
        }

        public double RemoverItem(double tempo)
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula anterior = primeiro;
            Celula atual = primeiro.Prox;

            while (atual != null && atual.Elemento != tempo)
            {
                anterior = atual;
                atual = atual.Prox;
            }

            double elemento = atual.Elemento;
            anterior.Prox = atual.Prox; 

          
            if (atual == ultimo)
            {
                ultimo = anterior;
            }

            return elemento;

        }
        public void Mostrar() {

            int count = 0;
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine($"{count}: {i.Elemento}");
                count++;
            }
        }
        
        public int Tamanho()
        {
            int tamanhoLista = 0;

            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                tamanhoLista++;
            }

            return tamanhoLista;
        }

        public int Contar(double tempo)
        {
            int resp = 0;

            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Elemento == tempo)
                {
                    resp++;
                }
            }

            return resp;
        }
    }
}
