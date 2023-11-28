using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade6
{
    public partial class frmExerc3 : Form
    {
        public frmExerc3()
        {
            InitializeComponent();
        }

        private void BtnRemover1_Click(object sender, EventArgs e)
        {
            int posicao = txtb2.Text.IndexOf(txtb1.Text, StringComparison.OrdinalIgnoreCase);

            while (posicao >= 0)
            {
                txtb2.Text = txtb2.Text.Substring(0, posicao) +
                    txtb2.Text.Substring(posicao + txtb1.Text.Length, txtb2.Text.Length
                    - posicao - txtb1.Text.Length);
                posicao = txtb2.Text.IndexOf(txtb1.Text, StringComparison.OrdinalIgnoreCase);

            }
        }

        private void BtnRemover2_Click(object sender, EventArgs e)
        {
            txtb2.Text = txtb2.Text.Replace(txtb1.Text, "");
        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtb1.Text.ToCharArray();
            Array.Reverse(vetor);
            // tenho que voltar para string 
            txtb2.Text = "";
            //foreach (var c in vetor)
            //    txtb2.Text += c;
            // outra forma 
            txtb2.Text = new string(vetor);// UM VETOR DE CHAR É DIFERENTE DE STRING
        }
    }
}
