using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Circulo
    {
        private double raio, area, diametro, perimetro;
        private const double Pi = 3.14;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double CalcularArea() 
        {
            area = Math.Round(Pi * (Math.Pow(raio, 2)),2);
            return area;
        }

        public double CalularDiametro()
        {
            diametro = Math.Round(raio * 2, 2);
            return diametro;
        }
        public double CalcularPerimetro()
        {
            perimetro = Math.Round(2 * Pi * raio, 2);
            return perimetro;
        }

        public void ImprimeInformacoes()
        {
            Console.WriteLine("Área: " + CalcularArea());
            Console.WriteLine("Diâmetro: " + CalularDiametro());
            Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }

    }
}
