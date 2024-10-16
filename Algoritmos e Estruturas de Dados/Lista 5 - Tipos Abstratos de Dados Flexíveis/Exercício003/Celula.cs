using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Celula
    {
        private Arquivo elemento;
        private Celula prox;

        public Celula(Arquivo elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = null;
            this.prox = null;
        }
        public Arquivo Elemento
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
