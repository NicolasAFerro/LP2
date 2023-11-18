using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica_lp2_aula01
{
    public partial class Form1 : Form 

    {
        Double raio;
        Double altura;// aqui vem da classe
        double volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtRaio_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("raio inválido!");
                txtRaio.Focus(); 
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("raio deve ser maior que zero");
                    txtRaio.Focus();
                }
            }
        }

        private void TxtAltura_Validating(object sender, CancelEventArgs e)
        { 
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("altura inválida");
                e.Cancel = true;// diretivas de cancelamento CaclcelEventArgs; 
            }
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("altura deve ser maior que zero");
                    e.Cancel = true;

                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close(); // tudo que tem parentese é metodo, oq não tem é propriedade;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();

            txtRaio.Focus(); // da foco no raio dai;
              
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");
        }
    }
}
