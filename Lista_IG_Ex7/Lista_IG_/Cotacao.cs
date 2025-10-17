using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_IG_
{
    internal class Cotacao
    {
        double cotacao;
        double dolar;
        double reaiz;

        public Cotacao()
        {
            this.cotacao = 0;
            this.dolar = 0;
            this.reaiz = 0;
        }
        public Cotacao(double cotacao, double dolar)
        {
            this.cotacao = cotacao;
            this.dolar = dolar;
        }
        public void setCotacao(double cotacao)
        {
            this.cotacao = cotacao;
        }
        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }
        public double getCotacao()
        {
            return this.cotacao;
        }
        public double getDolar()
        {
            return this.dolar;
        }
        public double getReais()
        {
            return this.reaiz;
        }
        public void calcularCotacao()
        {
            this.reaiz = this.cotacao * this.dolar;
        }
    }
}
