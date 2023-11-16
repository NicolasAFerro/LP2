namespace listaPratica
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sequenciaDivisao36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.InputVetor37 = new System.Windows.Forms.ToolStripMenuItem();
            this.Matriz38 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputboxMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaTrabalhoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.converterMedidas40 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.Matriz38,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sequenciaDivisao36});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem1.Text = "36";
            // 
            // sequenciaDivisao36
            // 
            this.sequenciaDivisao36.Name = "sequenciaDivisao36";
            this.sequenciaDivisao36.Size = new System.Drawing.Size(167, 22);
            this.sequenciaDivisao36.Text = "sequencia divisão";
            this.sequenciaDivisao36.Click += new System.EventHandler(this.sequenciaDivisao36_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputVetor37});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem2.Text = "37";
            // 
            // InputVetor37
            // 
            this.InputVetor37.Name = "InputVetor37";
            this.InputVetor37.Size = new System.Drawing.Size(152, 22);
            this.InputVetor37.Text = "inputBox vetor";
            this.InputVetor37.Click += new System.EventHandler(this.InputVetor37_Click);
            // 
            // Matriz38
            // 
            this.Matriz38.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputboxMatrizToolStripMenuItem});
            this.Matriz38.Name = "Matriz38";
            this.Matriz38.Size = new System.Drawing.Size(31, 20);
            this.Matriz38.Text = "38";
            // 
            // inputboxMatrizToolStripMenuItem
            // 
            this.inputboxMatrizToolStripMenuItem.Name = "inputboxMatrizToolStripMenuItem";
            this.inputboxMatrizToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inputboxMatrizToolStripMenuItem.Text = "inputbox Matriz";
            this.inputboxMatrizToolStripMenuItem.Click += new System.EventHandler(this.inputboxMatrizToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vagaTrabalhoMenu});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem4.Text = "39";
            // 
            // vagaTrabalhoMenu
            // 
            this.vagaTrabalhoMenu.Name = "vagaTrabalhoMenu";
            this.vagaTrabalhoMenu.Size = new System.Drawing.Size(146, 22);
            this.vagaTrabalhoMenu.Text = "vaga trabalho";
            this.vagaTrabalhoMenu.Click += new System.EventHandler(this.vagaTrabalhoMenu_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converterMedidas40});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem5.Text = "40";
            // 
            // converterMedidas40
            // 
            this.converterMedidas40.Name = "converterMedidas40";
            this.converterMedidas40.Size = new System.Drawing.Size(180, 22);
            this.converterMedidas40.Text = "Converter Medidas";
            this.converterMedidas40.Click += new System.EventHandler(this.converterMedidas40_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Matriz38;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sequenciaDivisao36;
        private System.Windows.Forms.ToolStripMenuItem InputVetor37;
        private System.Windows.Forms.ToolStripMenuItem inputboxMatrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaTrabalhoMenu;
        private System.Windows.Forms.ToolStripMenuItem converterMedidas40;
    }
}

