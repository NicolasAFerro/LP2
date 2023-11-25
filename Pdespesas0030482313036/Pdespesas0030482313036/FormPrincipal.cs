using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pdespesas0030482313036
{
    public partial class FormPrincipal : Form
    {
        public static SqlConnection conexao;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular

                conexao = new SqlConnection("Data Source=localhost\\sqlexpress02;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message, "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message, "Erro");
            }
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDespesa>().Count() > 0)
            {
                Application.OpenForms["frmDespesa"].BringToFront();
            }
            else
            {
                frmDespesa objDesp = new frmDespesa();
                objDesp.MdiParent = this;
                objDesp.WindowState = FormWindowState.Maximized;
                objDesp.Show();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms["frmSobre"].BringToFront();
            }
            else
            {
                frmSobre objSobre = new frmSobre();
                objSobre.MdiParent = this;
                objSobre.WindowState = FormWindowState.Maximized;
                objSobre.Show();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
