using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
{
    internal class CelulaDupla
    {
        private string elemento;
        private CelulaDupla prox;
        private CelulaDupla ant;
        public CelulaDupla(string elemento)
        {
            this.elemento = elemento;
            this.ant = null;
            this.prox = null;
        }
        public CelulaDupla()
        {
            this.elemento = "";
            this.ant = null;
            this.prox = null;
        }
        public CelulaDupla Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public CelulaDupla Ant
        {
            get { return ant; }
            set { ant = value; }
        }
        public string Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
    }
}
