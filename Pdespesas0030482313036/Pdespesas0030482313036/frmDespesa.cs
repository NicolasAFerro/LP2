﻿using System;
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
            this.WindowState = FormWindowState.Maximized;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }



            bnDespesa.AddNew();



            txtValor.Enabled = true;
            dtpData.Enabled = true;
            txtOBS.Enabled = true;
            cbxTipo.Enabled = true;



            cbxTipo.SelectedIndex = 0;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;



            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor;

            // validar os dados
            if (!Double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Valor inválido!");
            }
            else
            {
                Despesa RegDesp = new Despesa();



                RegDesp.Valordespesa = valor;
                RegDesp.Datadespesa = dtpData.Value;
                RegDesp.Obsdespesa = txtOBS.Text;
                RegDesp.Tipo_idtipo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegDesp.Incluir() > 0)
                    {
                        MessageBox.Show("Despesa adicionado com sucesso!");



                        txtValor.Enabled = false;
                        dtpData.Enabled = false;
                        txtOBS.Enabled = false;
                        cbxTipo.Enabled = false;



                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;



                        bInclusao = false;



                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDesp.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar despesa!");
                    }
                }
                else
                {
                    RegDesp.Iddespesa = Convert.ToInt32(txtID.Text);



                    if (RegDesp.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterada com sucesso!", "SUCESSO");



                        txtValor.Enabled = false;
                        dtpData.Enabled = false;
                        txtOBS.Enabled = false;
                        cbxTipo.Enabled = false;



                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;



                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDesp.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                    }
                    else
                    {



                        MessageBox.Show("Erro ao alterar despesa!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }



            txtValor.Enabled = true;
            dtpData.Enabled = true;
            txtOBS.Enabled = true;
            cbxTipo.Enabled = true;



            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;



            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Despesa RegDesp = new Despesa();
                RegDesp.Iddespesa = Convert.ToInt32(txtID.Text);



                if (RegDesp.Excluir() > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!", "SUCESSO");



                    // recarrega o grid
                    dsDespesa.Tables.Clear();
                    dsDespesa.Tables.Add(RegDesp.Listar());
                    bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir contato!", "ERRO");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnDespesa.CancelEdit();



            txtValor.Enabled = false;
            dtpData.Enabled = false;
            txtOBS.Enabled = false;
            cbxTipo.Enabled = false;



            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;



            bInclusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
