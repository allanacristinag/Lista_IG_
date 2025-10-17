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

        private void CalcularArea(object sender, EventArgs e)
        {
            Quadradodiag quadradodiag = new Quadradodiag();

            quadradodiag.setDiagonal(int.Parse(txt1.Text));

            quadradodiag.calcularArea();

            labelArea.Text = quadradodiag.getArea().ToString();
        }
    }
}
