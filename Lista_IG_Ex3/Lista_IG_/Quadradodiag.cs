using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_IG_
{
    internal class Quadradodiag
    {
        int diagonal;
        int a;

        public Quadradodiag()
        {
            this.diagonal = 0;
        }
        public Quadradodiag(int diagonal, int a)
        {
            this.diagonal = diagonal;
            this.a = a;
        }
        public void setDiagonal(int diagonal)
        {
            this.diagonal = diagonal;
        }
        public int getDiagonal()
        {
            return this.diagonal;
        }
        public int getArea()
        {
            return this.a;
        }
        public void calcularArea()
        {
            this.a = this.diagonal * this.diagonal / 2;
        }
    }
}
