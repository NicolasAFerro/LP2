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
    public partial class frmExerc4 : Form
    {
        public frmExerc4()
        {
            InitializeComponent();
        }

        private void BtnContNum_Click(object sender, EventArgs e)
        {
            var cont = 0;
            for( var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtFrase.Text[i]))
                    cont++;
            }

            MessageBox.Show("a frase contem: " + cont + " numero");
        }

        private void BtnBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int posicao = 0;
            while (cont < rchtxtFrase.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[cont]))
                {
                    posicao = cont + 1;
                    break;
                }
                cont++;
            }
            MessageBox.Show($"a posição do primeiro caracter em branco é {posicao}");
        }

        private void BtnContLetras_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach(var i in rchtxtFrase.Text)
            {
                if (char.IsLetter(i))
                {
                    cont++;
                }

            }
            MessageBox.Show($"a frase tem {cont} letras");
        }
    }
}
