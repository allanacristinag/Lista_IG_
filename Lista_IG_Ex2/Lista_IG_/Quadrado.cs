using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_IG_
{
    internal class Quadrado
    {
        double lado1;
        double a;

        public Quadrado()
        {
            this.lado1 = 0;

        }
        public Quadrado(double lado1)
        {
            this.lado1 = lado1;

        }
        public void setLAdo1(double lado1)
        {
            this.lado1 = lado1;
        }

        public double getLado1()
        {
            return this.lado1;
        }

        public double getArea()
        {
            return this.a;
        }
        public void calcularArea()
        {
            this.a = this.lado1 * lado1;
        }
    }
}
