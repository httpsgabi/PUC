using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Pilha
    {
        private Celula topo;

        public Pilha(){
            topo = null;
        }

        public void Inserir(char caracter){

            Celula tmp = new Celula(caracter);

            tmp.Prox = topo;
            topo = tmp;

            tmp = null;
        }
        public char Remover()
        {
            if (topo == null)
            {
                throw new Exception ("Erro, pilha vazia!");
            }

            char elementoRemovido = topo.Elemento;

            Celula tmp = topo;
            topo = topo.Prox;

            tmp.Prox = null;
            tmp = null;

            return elementoRemovido;

        }

        public void Mostrar()
        {
            for (Celula i = topo; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }

        public bool EstaVazia()
        {
            bool listaVazia = true;

            if(topo != null)
            {
                listaVazia = false;
            }

            return listaVazia;
        }
    }

}
