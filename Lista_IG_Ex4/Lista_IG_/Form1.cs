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

        private void CalcularTriangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.setBase(double.Parse(txt1.Text));
            triangulo.setAltura(double.Parse(txt2.Text));

            triangulo.calcularArea();

            labelArea.Text = triangulo.getArea().ToString();
        }
    }
}
