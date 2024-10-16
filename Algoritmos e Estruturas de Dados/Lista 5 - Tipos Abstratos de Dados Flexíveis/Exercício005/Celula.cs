using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Celula
    {
        private double elemento;
        private Celula prox;

        public Celula(double elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }

        public Celula()
        {
            this.elemento = 0;
            this.prox = null;
        }

        public double Elemento
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
