using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        string operd = "";
        

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
            {
                string expressao = txbTela.Text;
                if (expressao.Contains("/0"))
                {
                    MessageBox.Show("NAO PODE DIVIDIR POR ZERO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTela.Clear();
                    return;
                }
                var resultado = new DataTable().Compute(expressao, null);
                txbTela.Text = resultado.ToString();
            }
        }
        private void numero_Click(object sender, EventArgs e)
        {
           Button botaoClicado = (Button)sender;

            txbTela.Text += botaoClicado.Text;

            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            if (!operadorClicado)
            {
                Button botaoClicado = (Button)sender;

                operd = botaoClicado.Text;

                txbTela.Text += operd;

                operadorClicado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTela.Text = "";

            operadorClicado = true;
        }

    }
}
