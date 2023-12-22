namespace FacoQuaseTudo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnBuscaServico = new System.Windows.Forms.Button();
            this.btnAddServico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(331, 34);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(149, 68);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastrar Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnBuscaServico
            // 
            this.btnBuscaServico.Location = new System.Drawing.Point(331, 274);
            this.btnBuscaServico.Name = "btnBuscaServico";
            this.btnBuscaServico.Size = new System.Drawing.Size(149, 68);
            this.btnBuscaServico.TabIndex = 1;
            this.btnBuscaServico.Text = "Buscar Serviço";
            this.btnBuscaServico.UseVisualStyleBackColor = true;
            this.btnBuscaServico.Click += new System.EventHandler(this.btnBuscaServico_Click);
            // 
            // btnAddServico
            // 
            this.btnAddServico.Location = new System.Drawing.Point(331, 165);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(149, 68);
            this.btnAddServico.TabIndex = 2;
            this.btnAddServico.Text = "Adicionar Serviço";
            this.btnAddServico.UseVisualStyleBackColor = true;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddServico);
            this.Controls.Add(this.btnBuscaServico);
            this.Controls.Add(this.btnCadastroCliente);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnBuscaServico;
        private System.Windows.Forms.Button btnAddServico;
    }
}

