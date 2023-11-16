using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdespesas0030482313036
{
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource(); 
        private bool bInclusao = false; 
        private DataSet dsDespesa = new DataSet(); 
        private DataSet dsTipo = new DataSet();

        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                Despesa Con = new Despesa();
                dsDespesa.Tables.Add(Con.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;



                txtID.DataBindings.Add("TEXT", bnDespesa, "IDDESPESA");
                txtValor.DataBindings.Add("TEXT", bnDespesa, "VALORDESPESA");
                dtpData.DataBindings.Add("TEXT", bnDespesa, "DATADESPESA");
                txtOBS.DataBindings.Add("TEXT", bnDespesa, "OBSDESPESA");





                // carrega dados do tipo
                Tipo ObjT = new Tipo();
                dsTipo.Tables.Add(ObjT.Listar());
                cbxTipo.DataSource = dsTipo.Tables["Tipo"];
                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO
                cbxTipo.DisplayMember = "descricaotipo";
                //CAMPO QUE É A CHAVE DA TABELA TIPO E QUE LIGA COM A TABELA DE DESPESA
                cbxTipo.ValueMember = "idtipo";
                //linkar combox do tipo
                cbxTipo.DataBindings.Add("SelectedValue",
                    bnDespesa, "TIPO_IDTIPO"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR DIGITAR
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        
        }
    }
}
