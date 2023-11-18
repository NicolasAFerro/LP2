namespace atividade6
{
    partial class frmExerc5
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
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbNum1
            // 
            this.txtbNum1.Location = new System.Drawing.Point(248, 82);
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(234, 26);
            this.txtbNum1.TabIndex = 0;
            // 
            // txtbNum2
            // 
            this.txtbNum2.Location = new System.Drawing.Point(683, 82);
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(307, 26);
            this.txtbNum2.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(314, 38);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(82, 20);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "1º número";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(781, 38);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(82, 20);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "2º número";
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(495, 204);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(156, 78);
            this.btnSorteio.TabIndex = 4;
            this.btnSorteio.Text = "Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.BtnSorteio_Click);
            // 
            // frmExerc5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 471);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbNum1);
            this.Name = "frmExerc5";
            this.Text = "frmExerc5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNum1;
        private System.Windows.Forms.TextBox txtbNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnSorteio;
    }
}