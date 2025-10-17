using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_IG_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularCotacao(object sender, EventArgs e)
        {
            Cotacao cotacao = new Cotacao();
            cotacao.setCotacao(double.Parse(txt1.Text));
            cotacao.setDolar(double.Parse(txt2.Text));

            cotacao.calcularCotacao();

            labelCotacao.Text = cotacao.getReais().ToString();
        }
    }
}
