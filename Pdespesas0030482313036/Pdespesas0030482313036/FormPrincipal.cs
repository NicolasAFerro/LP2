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
    }
}
