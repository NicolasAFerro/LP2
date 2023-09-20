using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3
{
    public partial class Form2 : Form
    {
        double altura, peso, imc;

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair mesmo?", "saida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Text = "";
            mskbxPeso.Text = "";
            mskbxPeso.Focus();

        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxPeso.Text, out peso)|| peso > 600)
            {

                MessageBox.Show("peso deve ser menor que 600,00kg");
                //MessageBox.Show("numero inválido");
                mskbxPeso.Focus();
            }
        }

        private void mskbxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxAltura.Text, out altura) || altura > 3.00)
            { 
                MessageBox.Show("altura deve ser menor que 3m");
                //MessageBox.Show("altura inválida");
                mskbxAltura.Focus();
            }

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // CALCULAR O IMC
            imc = peso/(altura*altura);
            //MessageBox.Show("IMC" + imc.ToString());
            //MessageBox.Show("peso" + peso.ToString());
            //.Show("altura" + altura.ToString());

            if (imc < 18.5)
            {
                MessageBox.Show("MAGREZA");
            }
            else if (imc < 24.9)
            {
                MessageBox.Show("NORMAL");

            }
            else if (imc <= 29.9)
            {
                MessageBox.Show("SOBREPESO");
            }
            else if (imc <= 39.9)
            {
                MessageBox.Show("OBESIDADE");
            }
            else { MessageBox.Show("OBESIDADE GRAVE"); }
            txtResultadoIMC.Text = imc.ToString();
        }

    
    }
}
