using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoHash
{
    internal class Lista
    {
        private Celula primeiro, ultimo;

        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public Tamanho()
        {
            for
        }
        void InserirInicio(int x)
        {
            Celula celula = new Celula();
            celula.Prox = primeiro.Prox;
            primeiro.Prox = celula;

            if(primeiro == ultimo)
            {
                ultimo = celula;
            }

            celula = null;
        }

        public bool Pesquisar(int x)
        {
            bool resp = false;

            for (Celula i= primeiro.Prox; i != null; i = i.Prox) {

                if (i.Elemento == x)
                {
                    resp = true;
                    i = ultimo;
                }
            }

            return resp;
        }

        public void Remover(int x)
        {
            if (primeiro == ultimo || x >= Tamanho()) {
                throw new Exception ("Erro");
            }

            if(x == 0){
                RemoverInicio(x);
            })

            
            Celula i = primeiro;

            for (int i = 0; i < x; j++, i = i.Prox)
            {
                if(i.Elemento)
            }
        }
    }
}
