using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Aluno
    {
        private string nome;
        private int nota;

        public Aluno()
        {
            this.nome = "";
            this.nota = 0;
        }

        public string Nome
        {

            get { return nome; }
            set { nome = value; }
        }

        public int Nota
        {

            get { return nota; }
            set { nota = value; }
        }
    }
}
