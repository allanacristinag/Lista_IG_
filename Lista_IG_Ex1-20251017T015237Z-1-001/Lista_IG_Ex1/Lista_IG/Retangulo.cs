using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_IG
{
    internal class Retangulo
    {
        
        private double b;
        private double h;
        private double a;

        public Retangulo()
        {
            this.b = 0;
            this.h = 0;
        }
        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public void setBase(double b)
        {
            this.b = b;
        }
        public void setAltura(double h)
        {
            this.h = h;
        }
        public double getBase()
        {
            return this.b;
        }
        public double getAltura()
        {
            return this.h;
        }
        public double getArea()
        {
            return this.a;
        }
        public void calcularArea()
        {
            this.a = this.b * this.h;
        }
    }
}
