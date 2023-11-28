namespace atividade6
{
    partial class frmExerc4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnContNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnContLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(250, 146);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(488, 170);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(337, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Frase";
            // 
            // btnContNum
            // 
            this.btnContNum.Location = new System.Drawing.Point(212, 353);
            this.btnContNum.Name = "btnContNum";
            this.btnContNum.Size = new System.Drawing.Size(132, 51);
            this.btnContNum.TabIndex = 2;
            this.btnContNum.Text = "Conta Numeros";
            this.btnContNum.UseVisualStyleBackColor = true;
            this.btnContNum.Click += new System.EventHandler(this.BtnContNum_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(408, 353);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(217, 51);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Posição primeiro caracter em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.BtnBranco_Click);
            // 
            // btnContLetras
            // 
            this.btnContLetras.Location = new System.Drawing.Point(672, 353);
            this.btnContLetras.Name = "btnContLetras";
            this.btnContLetras.Size = new System.Drawing.Size(181, 51);
            this.btnContLetras.TabIndex = 4;
            this.btnContLetras.Text = "Conta Letras";
            this.btnContLetras.UseVisualStyleBackColor = true;
            this.btnContLetras.Click += new System.EventHandler(this.BtnContLetras_Click);
            // 
            // frmExerc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 432);
            this.Controls.Add(this.btnContLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnContNum);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExerc4";
            this.Text = "frmExerc4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnContNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnContLetras;
    }
}