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
    public partial class frmExerc5 : Form
    {
        public frmExerc5()
        {
            InitializeComponent();
        }

        private void BtnSorteio_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2; 
            if(!int.TryParse(txtbNum1.Text, out numero1)|| !int.TryParse(txtbNum2.Text, out numero2))
            {
                MessageBox.Show("DADOS INVÁLIDOS!");
            }
            else
            {
                if( numero1<=0 || numero2<=0 || numero1 >= numero2)
                {
                    MessageBox.Show(" o numero 1 deve ser maior que o numero dois ou os numeros ão negativos");
                    txtbNum1.Focus();
                }
                else
                {
                    Random objR = new Random();
                    int aleatorio = objR.Next(numero1, numero2);
                    MessageBox.Show($"o vencedor é o número: {aleatorio}");
                }
            }
        }
    }
}
