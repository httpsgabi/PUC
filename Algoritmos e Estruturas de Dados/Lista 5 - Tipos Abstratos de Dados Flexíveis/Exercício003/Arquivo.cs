using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Arquivo
    {
        private string nome;
        private int numPaginas;

        public Arquivo(string nome, int numPaginas)
        {
            this.nome = nome;
            this.numPaginas = numPaginas;
        }

        public string Nome
        {
            get { return this.nome; } 
            set { nome = value; }

        }

        public int NumPaginas
        {
            get { return this.numPaginas; }
            set { numPaginas = value; }
        }
    }
}
