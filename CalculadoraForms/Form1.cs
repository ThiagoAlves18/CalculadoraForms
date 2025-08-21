using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        bool operadorClicado = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }
        private void numero_Click(object sender, EventArgs e)
        {
           Button botaoClicado = (Button)sender;

            txbTela.Text += botaoClicado.Text;

            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            if (operadorClicado == false)
            {
                Button botaoClicado = (Button)sender;

                txbTela.Text += botaoClicado.Text;

                operadorClicado = true;
            }
           
        }

    }
}
