using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double resultado, numero1, numero2;





        private void BtnSoma_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();

        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                MessageBox.Show("não pode dividir por 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum2.Focus();
            }
            resultado = numero1 / numero2;
            txtResultado.Text = resultado.ToString();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voce deseja sair mesmo?", "saida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("numero 2 inválido");
                txtNum2.Focus();

            }
        }

        private void Txtnum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtnum1.Text, out numero1))
            {
                MessageBox.Show("numero 1 inválido");
                txtnum1.Focus();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";

            lblNum1.Focus();
            resultado = 0;
            numero1 = 0;
            numero2 = 0;

            

        }
    }
}
