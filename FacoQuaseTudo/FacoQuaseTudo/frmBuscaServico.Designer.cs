namespace FacoQuaseTudo
{
    partial class frmBuscaServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBLote = new System.Windows.Forms.TextBox();
            this.txtBQuadra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lb10Servicos = new System.Windows.Forms.ListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // txtBLote
            // 
            this.txtBLote.Location = new System.Drawing.Point(457, 113);
            this.txtBLote.Name = "txtBLote";
            this.txtBLote.Size = new System.Drawing.Size(100, 20);
            this.txtBLote.TabIndex = 25;
            // 
            // txtBQuadra
            // 
            this.txtBQuadra.Location = new System.Drawing.Point(289, 114);
            this.txtBQuadra.Name = "txtBQuadra";
            this.txtBQuadra.Size = new System.Drawing.Size(100, 20);
            this.txtBQuadra.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quadra";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(55, 49);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente";
            // 
            // lb10Servicos
            // 
            this.lb10Servicos.FormattingEnabled = true;
            this.lb10Servicos.Location = new System.Drawing.Point(58, 183);
            this.lb10Servicos.Name = "lb10Servicos";
            this.lb10Servicos.Size = new System.Drawing.Size(322, 199);
            this.lb10Servicos.TabIndex = 27;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(489, 267);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(180, 115);
            this.btnExecutar.TabIndex = 28;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBuscaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lb10Servicos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBLote);
            this.Controls.Add(this.txtBQuadra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmBuscaServico";
            this.Text = "Buscar Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBLote;
        private System.Windows.Forms.TextBox txtBQuadra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ListBox lb10Servicos;
        private System.Windows.Forms.Button btnExecutar;
    }
}