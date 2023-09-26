using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeiro
{
    public partial class Form1 : Form
    {
        double descontoINSS, descontoIRPF, salarioFamilia, salarioLiquido;
        public Form1()
        {
            InitializeComponent();
        }
        double salario, numeroFilhos;

        private void msktxtSalario_Validated(object sender, EventArgs e)
        {   errorProvider1.SetError(msktxtSalario,"");
            if(!double.TryParse(msktxtSalario.Text, out salario))
            {
                errorProvider1.SetError(msktxtSalario, "salario obrigatório");
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("nome obrigatório");
                txtNome.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                ///INSS
            if (salario <= 800.47)
            {
                txtINSS.Text = "7,65%";
                descontoINSS = 0.076 * salario;
                txtDescINSS.Text = descontoINSS.ToString();
            } else if (salario <= 1050)
            {
                txtINSS.Text = "8,65%";
                descontoINSS = 0.0865 * salario;
                txtDescINSS.Text = descontoINSS.ToString();

            }
            else if (salario <= 1400.77)
            {
                txtINSS.Text = "9,00%";
                descontoINSS = 0.09 * salario;
                txtDescINSS.Text = descontoINSS.ToString();
            }
            else if (salario <= 2801.56)
            {
                txtINSS.Text = "11%";
                descontoINSS = 0.11 * salario;
                txtDescINSS.Text = descontoINSS.ToString();
            }
            else
            {
                txtINSS.Text = "teto";
                descontoINSS = 308.17;
                txtDescINSS.Text = descontoINSS.ToString();
            }

                //IRPF
            if (salario <= 1257.12)
            {
                txtDescIRPF.Text = "isento";
            }else if (salario <= 2512.08)
            {
                descontoIRPF = salario * 0.15;
                txtDescIRPF.Text = descontoIRPF.ToString();
                txtIRPF.Text = "15%";

            }
            else
            {
                descontoIRPF = salario * 0.275; 
                txtDescIRPF.Text= descontoIRPF.ToString();
                txtIRPF.Text = "27,5%";
            }

            //FAMILIA
            if (salario <= 435.52)
            {
                salarioFamilia = 22.53 * numeroFilhos;
                txtSalFamilia.Text = salarioFamilia.ToString();

            }else if (salario <= 654.61)
            {
                salarioFamilia = 15.74 * numeroFilhos;
                txtSalFamilia.Text = salarioFamilia.ToString();
            }
            else
            {
                salarioFamilia = 0 * numeroFilhos;
                txtSalFamilia.Text = salarioFamilia.ToString();
            }

            salarioLiquido = salario - descontoINSS - descontoIRPF + salarioFamilia;
            txtSalLiq.Text=salarioLiquido.ToString();
            

        }

       

        private void nupdFilho_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(nupdFilho, "");
            if(!double.TryParse(nupdFilho.Text, out numeroFilhos))
            {
                errorProvider2.SetError(nupdFilho, "erro campo filhos");
            }
        }
        
       




        /*private void txtNome_Validated(object sender, EventArgs e)
        {
            for (int i = 0; i < txtNome.TextLength; i++)
            {
                if ((txtNome.Text[i] < 65 || txtNome.Text[i] > 90) && (txtNome.Text[i] < 97 || txtNome.Text[i] > 122))
                {
                    MessageBox.Show("erro no nome");
                }
            }
        }*/
    }
}
