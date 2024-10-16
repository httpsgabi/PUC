using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Celula
    {
        private char elemento;
        private Celula prox;

        public Celula(char elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }

        public Celula()
        {
            this.elemento = ' ';
            this.prox = null;
        }

        public char Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }

    }
    
}
