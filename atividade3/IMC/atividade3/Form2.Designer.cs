namespace atividade3
{
    partial class Form2
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
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtResultadoIMC = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(342, 173);
            this.mskbxAltura.Mask = "0.99";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskbxAltura.TabIndex = 17;
            this.mskbxAltura.Validated += new System.EventHandler(this.mskbxAltura_Validated);
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(342, 110);
            this.mskbxPeso.Mask = "000.99";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(100, 20);
            this.mskbxPeso.TabIndex = 16;
            this.mskbxPeso.Validated += new System.EventHandler(this.mskbxPeso_Validated);
            // 
            // txtResultadoIMC
            // 
            this.txtResultadoIMC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultadoIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultadoIMC.Location = new System.Drawing.Point(342, 220);
            this.txtResultadoIMC.Name = "txtResultadoIMC";
            this.txtResultadoIMC.Size = new System.Drawing.Size(145, 13);
            this.txtResultadoIMC.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(512, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 64);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(374, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 64);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(233, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 64);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(176, 222);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(38, 19);
            this.lblIMC.TabIndex = 11;
            this.lblIMC.Text = "IMC";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(176, 174);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 19);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Altura";
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoAtual.Location = new System.Drawing.Point(176, 112);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(90, 19);
            this.lblPesoAtual.TabIndex = 9;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.txtResultadoIMC);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPesoAtual);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.TextBox txtResultadoIMC;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoAtual;
    }
}