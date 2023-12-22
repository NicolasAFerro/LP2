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

namespace FacoQuaseTudo
{
    public partial class Form1 : Form

    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
           frmCliente NovoCliente = new frmCliente();
           //NovoCliente.MdiParent = this;
           NovoCliente.WindowState = FormWindowState.Maximized;
           NovoCliente.Show();
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            frmServico NovoServico = new frmServico(); 
            
            NovoServico.WindowState= FormWindowState.Maximized; 
            NovoServico.Show();
        }

        private void btnBuscaServico_Click(object sender, EventArgs e)
        {
            frmBuscaServico BuscaServico = new frmBuscaServico(); 
            
            BuscaServico.WindowState = FormWindowState.Maximized;
            BuscaServico.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular

                conexao = new SqlConnection("Data Source=localhost\\sqlexpress02;Initial Catalog=FacoQuaseTudo;Integrated Security=True;Pooling=False");
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
    }
}
