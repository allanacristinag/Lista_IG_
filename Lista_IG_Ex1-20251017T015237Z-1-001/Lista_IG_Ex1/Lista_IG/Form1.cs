using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_IG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularRetangulo(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.setBase(int.Parse(txtBase.Text));
            retangulo.setAltura(int.Parse(txtAltura.Text));

            retangulo.calcularArea();
            
            lblArea.Text = retangulo.getArea().ToString();

        }

        private void checaPreenchimento(object sender, EventArgs e)
        {
            Calcular.Enabled = (label1.Text != "" && label2.Text != "");
        }

    }
}
