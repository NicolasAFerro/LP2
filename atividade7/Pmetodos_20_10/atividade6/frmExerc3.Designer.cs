namespace atividade6
{
    partial class frmExerc3
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
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnRemover1 = new System.Windows.Forms.Button();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(512, 277);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(108, 64);
            this.btnInverte.TabIndex = 13;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.BtnInverte_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.Location = new System.Drawing.Point(369, 277);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(117, 64);
            this.btnRemover2.TabIndex = 12;
            this.btnRemover2.Text = "Remover 2";
            this.btnRemover2.UseVisualStyleBackColor = true;
            this.btnRemover2.Click += new System.EventHandler(this.BtnRemover2_Click);
            // 
            // btnRemover1
            // 
            this.btnRemover1.Location = new System.Drawing.Point(207, 277);
            this.btnRemover1.Name = "btnRemover1";
            this.btnRemover1.Size = new System.Drawing.Size(110, 64);
            this.btnRemover1.TabIndex = 11;
            this.btnRemover1.Text = "Remover 1";
            this.btnRemover1.UseVisualStyleBackColor = true;
            this.btnRemover1.Click += new System.EventHandler(this.BtnRemover1_Click);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(327, 177);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(245, 26);
            this.txtb2.TabIndex = 10;
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(327, 109);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(245, 26);
            this.txtb1.TabIndex = 9;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(180, 180);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 8;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(180, 109);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 7;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // frmExerc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover1);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExerc3";
            this.Text = "frmExerc3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnRemover1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
    }
}