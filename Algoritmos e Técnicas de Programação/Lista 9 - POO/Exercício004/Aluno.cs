using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Aluno
    {
        private long matricula;
        private float[] notas = new float[10];
        private double media = 0;

        public Aluno(long matricula, float[] notas)
        {
            this.matricula = matricula;
            this.notas = notas;
        }

        public double CalculaMedia()
        {
            media = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                media += notas[i];
            }

            media = media / notas.Length;

            return Math.Round(media, 2);
        }

        public void ImprimeInformacoes()
        {
            double mediaCalculada = CalculaMedia();
            Console.WriteLine($"O aluno de matrícula {matricula} teve média: {mediaCalculada}");
        }
    }
}
