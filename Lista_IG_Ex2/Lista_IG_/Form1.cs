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

        private void CalcularQuadrado(object sender, EventArgs e)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.setLAdo1(double.Parse(txt1.Text));

            quadrado.calcularArea();

            labelArea.Text = quadrado.getArea().ToString();
        }
    }
}
