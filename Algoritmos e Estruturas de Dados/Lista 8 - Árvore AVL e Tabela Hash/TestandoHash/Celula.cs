using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoHash
{
    internal class Celula
    {
        private int elemento;
        private Celula prox;

        public Celula()
        {
            elemento = 0;
            prox = null;
        }

        public Celula(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public int Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

        public Celula Prox { 
            get { return prox; }
            set { prox = value; }   
        }

    }
}
