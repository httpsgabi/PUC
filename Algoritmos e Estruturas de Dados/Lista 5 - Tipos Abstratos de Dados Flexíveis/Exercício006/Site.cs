using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class Site
    {
        private string nome;
        private string link;

        public Site(string nome, string link)
        {
            this.nome = nome;
            this.link = link;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Link {  

            get { return link; } 
            set {  link = value; } 

        }
    }
}
