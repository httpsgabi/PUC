using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9_Extra
{
    internal class Jogador
    {
        private int id, anoNasc;
        private string nome, universidade, estadoNasc;
        private double altura, peso;

        public Jogador()
        {
            id = 0;
            anoNasc = 0;
            nome = "";
            universidade = "";
            estadoNasc = "";
            altura = 0.0;
            peso = 0.0; 
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Universidade
        {
            get { return universidade; }
            set { universidade = value; }
        }

        public int AnoNasc
        {
            get { return anoNasc; }
            set { anoNasc = value; }
        }

        public string EstadoNasc {
            get { return estadoNasc; }
            set { estadoNasc = value; }
        }

    }
}
