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
    public partial class emprego39 : Form
    {
        public emprego39()
        {
            InitializeComponent();
        }

        private void btnCandidatar_Click(object sender, EventArgs e)
        {
            double salario;
            if (!double.TryParse(mskBSalario.Text, out salario))
            {
                MessageBox.Show("salario inválido");
            } else
            {
                if (salario < 1000 | salario > 2500)
                    MessageBox.Show("sua pretenção não é compativel com a vaga");
                else if (comboBoxDistancia.SelectedIndex == 3)
                    MessageBox.Show("essa vaga não pe home office");
                else if (comboBoxTempoExperiencia.SelectedIndex == 1)
                    MessageBox.Show("aguardar a entrevista");
                else if (comboBoxTempoExperiencia.SelectedIndex == 0)
                    MessageBox.Show("obrigado pela candidatura, mas você não atende os requisitos");
            }
            if (txtNome.Text == "")
                MessageBox.Show("nome obrigatório");
            if (txtTelefone.Text == "")
                MessageBox.Show("telefone obrigatório");
            if (comboBox1.Text == "")
                MessageBox.Show("idade obrigatória");

        }

        /*foreach(var x in this.controls emprego39){  
            }*/

      

        private void txtTelefone_Validated(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
                MessageBox.Show("telefone obrigatório");
            txtNome.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("idade obrigatória"); 
            
        }

        private void comboBoxDistancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistancia.Text == "")
            {
                MessageBox.Show("distância obrigatória");
               comboBoxDistancia.Focus();

            }

        }

        private void txtbUltimaEmpresa_Validating(object sender, CancelEventArgs e)
        {
            if (txtbUltimaEmpresa.Text == ""){
                MessageBox.Show("ultima empresa é campo obrigatório");
                txtbUltimaEmpresa.Focus();

            }

        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("selecione uma idade");
                txtNome.Focus();

            }
                
        }

        private void comboBoxDistancia_Validated(object sender, EventArgs e)
        {
            if(comboBoxDistancia.Text == null)
            {
                MessageBox.Show("selecione uma distancia");
               comboBoxDistancia.Focus();
            
            }
        }

        private void comboBoxTempoExperiencia_Validated(object sender, EventArgs e)
        {
            if(comboBoxTempoExperiencia.Text == null)
            {
                MessageBox.Show("tempo de experiencia inválido"); 
               comboBoxTempoExperiencia.Focus();
            }
        }

        private void mskBSalario_Validated(object sender, EventArgs e)
        {
            if(mskBSalario.Text == null)
            {
                MessageBox.Show("salario obrigatório"); 
               mskBSalario.Focus();
            }
        }

        private void groupBestadoCivil_Validated(object sender, EventArgs e)
        {

        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text == null)
            {
                MessageBox.Show("nome obrigatório");
                txtNome.Focus();
            }
        }
    }
}
