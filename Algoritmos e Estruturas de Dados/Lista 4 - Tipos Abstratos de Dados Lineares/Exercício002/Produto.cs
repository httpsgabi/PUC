using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Produto
    {
        private string nome;
        private int quant;
        private double preco;

        public Produto(string nome, int quant, double preco)
        {
            this.nome = nome;
            this.quant = quant;
            this.preco = preco;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Quant
        {
            get { return quant; }
            set { quant = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public override string ToString()
        {
            return $"[nome: {nome}, quantidade: {quant}, preco: {preco}]";
        }
    }
}
