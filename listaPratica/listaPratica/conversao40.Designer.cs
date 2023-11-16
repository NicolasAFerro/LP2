namespace listaPratica
{
    partial class conversao40
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.txtBesquerda = new System.Windows.Forms.TextBox();
            this.txtBdireita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBseta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade de Conversão";
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Items.AddRange(new object[] {
            "De Arroba Para Quilo ",
            "De Libra Para Quilo  ",
            "De Onça Para Grama ",
            "De Acre Para Hectare ",
            "De Hectare Para Metro2  ",
            "De AlqueireMG Para Hectare ",
            "De AlqueireSP Para Hectare ",
            "De AlqueireNorte Para Hectare  ",
            "De Braça Para Metro ",
            "De Jarda Para Metro ",
            "De Pé Para Centímetro ",
            "De Polegada Para Centímetro  ",
            "De Milha Para Quilometro"});
            this.comboBoxUnidade.Location = new System.Drawing.Point(251, 51);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(280, 21);
            this.comboBoxUnidade.TabIndex = 1;
            this.comboBoxUnidade.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidade_SelectedIndexChanged);
            // 
            // txtBesquerda
            // 
            this.txtBesquerda.Location = new System.Drawing.Point(89, 117);
            this.txtBesquerda.Name = "txtBesquerda";
            this.txtBesquerda.Size = new System.Drawing.Size(197, 20);
            this.txtBesquerda.TabIndex = 2;
            this.txtBesquerda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBesquerda_KeyDown);
            this.txtBesquerda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBesquerda_PreviewKeyDown);
            // 
            // txtBdireita
            // 
            this.txtBdireita.Location = new System.Drawing.Point(524, 117);
            this.txtBdireita.Name = "txtBdireita";
            this.txtBdireita.Size = new System.Drawing.Size(197, 20);
            this.txtBdireita.TabIndex = 3;
            this.txtBdireita.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBdireita_KeyDown);
            this.txtBdireita.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBdireita_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "valor1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "valor2";
            // 
            // txtBseta
            // 
            this.txtBseta.Location = new System.Drawing.Point(346, 117);
            this.txtBseta.Name = "txtBseta";
            this.txtBseta.Size = new System.Drawing.Size(100, 20);
            this.txtBseta.TabIndex = 10;
            this.txtBseta.Text = "--->";
            // 
            // conversao40
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBseta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBdireita);
            this.Controls.Add(this.txtBesquerda);
            this.Controls.Add(this.comboBoxUnidade);
            this.Controls.Add(this.label1);
            this.Name = "conversao40";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUnidade;
        private System.Windows.Forms.TextBox txtBesquerda;
        private System.Windows.Forms.TextBox txtBdireita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBseta;
    }
}