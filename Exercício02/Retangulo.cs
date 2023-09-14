using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    public class Retangulo
    {
        private double altura, largura, area;

        public Retangulo(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
            CalcularArea();
        }
        private void CalcularArea()
        {
            area = altura * largura;
        }
        public double Altura { get => altura; set => altura = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Area { get => area;}
    }
}
