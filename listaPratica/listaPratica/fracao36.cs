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
    public partial class fracao36 : Form
    {
        public fracao36()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int numero;
            float soma = 0;
            if (int.TryParse(txtBnumero.Text, out numero))
            {
                if ((numero > 50) || (numero < 0))
                    MessageBox.Show("numero deve estar entre 50 e 0");
            }
            else
                MessageBox.Show("Insira um numero inteiro");
            for (int i = 1; i <= numero; i++)
            {
                soma += (float)i /(i + 1);
            }
            txtbResultado.Text = soma.ToString();

        }
        
    }
}
