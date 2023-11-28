namespace WindowsFormsApp1
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
            this.button2 = new System.Windows.Forms.Button();
            this.mskbxValor1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskbxValor2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(387, 237);
            this.button2.TabIndex = 1;
            this.button2.Text = "Teste aspas duplas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskbxValor1
            // 
            this.mskbxValor1.Location = new System.Drawing.Point(822, 150);
            this.mskbxValor1.Margin = new System.Windows.Forms.Padding(5);
            this.mskbxValor1.Mask = "999999.99";
            this.mskbxValor1.Name = "mskbxValor1";
            this.mskbxValor1.Size = new System.Drawing.Size(569, 34);
            this.mskbxValor1.TabIndex = 2;
            this.mskbxValor1.Leave += new System.EventHandler(this.mskbxValor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor1 (preenche com zeros direita e esquerda)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor2 (preenche zeros a esquerda e vai para o decimal)";
            // 
            // mskbxValor2
            // 
            this.mskbxValor2.Location = new System.Drawing.Point(822, 263);
            this.mskbxValor2.Margin = new System.Windows.Forms.Padding(5);
            this.mskbxValor2.Mask = "999999.99";
            this.mskbxValor2.Name = "mskbxValor2";
            this.mskbxValor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskbxValor2.Size = new System.Drawing.Size(569, 34);
            this.mskbxValor2.TabIndex = 5;
            this.mskbxValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxValor2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.mskbxValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskbxValor1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "DIVERSOS TESTES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mskbxValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskbxValor2;
    }
}

