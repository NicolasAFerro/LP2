using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaPratica
{
    public partial class conversao40 : Form
    {
        public conversao40()
        {
            InitializeComponent();
        }
        double valorEsquerda, valorDireita, resultado;

        private void txtBesquerda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conversao();
            }
        }

        private void txtBdireita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conversao();
            }
        }

        private void txtBdireita_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            txtBseta.Text = "<---";


        }

        private void txtBesquerda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            txtBseta.Text = "--->";
        }

        public void conversao()
        {
            if (txtBesquerda.Text != "")
                if (!double.TryParse(txtBesquerda.Text, out valorEsquerda))
                    MessageBox.Show("valor esquerda inválido");
            if (txtBdireita.Text != "")
                if (!double.TryParse(txtBdireita.Text, out valorDireita))
                    MessageBox.Show("valor direita inválido");
            switch (comboBoxUnidade.SelectedIndex)
            {
                case 0:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 15 : valorDireita / 15);
                    break;
                case 1:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 0.4535923 : valorDireita / 0.4535923);
                    break;
                case 2:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 28.349 : valorDireita / 28.349);
                    break;
                case 3:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 0.4046856224 : valorDireita / 0.4046856224);
                    break;
                case 4:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 10000.0 : valorDireita / 10000.0);
                    break;
                case 5:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 4.84 : valorDireita / 4.84);
                    break;
                case 6:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 2.42 : valorDireita / 2.42);
                    break;
                case 7:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 2.72 : valorDireita / 2.72);
                    break;
                case 8:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 1.8288 : valorDireita / 1.8288);
                    break;
                case 9:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 0.9144 : valorDireita / 0.9144);
                    break;
                case 10:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 30.48 : valorDireita / 30.48);
                    break;
                case 11:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 2.54 : valorDireita / 2.54);
                    break;
                case 12:
                    resultado = (txtBseta.Text == "--->" ? valorEsquerda * 1.609344 : valorDireita / 1.609344);
                    break;
                default: break;
            }
            if (txtBseta.Text == "--->")
            {
                txtBdireita.Text = resultado.ToString();
               
            }
            else
            {
                txtBesquerda.Text = resultado.ToString();
              

            }
                

        }

        private void comboBoxUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBdireita.Clear();
            txtBesquerda.Clear();
        }

       
    }
}


