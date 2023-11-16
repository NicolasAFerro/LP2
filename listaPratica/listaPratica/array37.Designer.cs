namespace listaPratica
{
    partial class array37
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.ListBArray = new System.Windows.Forms.ListBox();
            this.ListBMatriz = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(306, 43);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(197, 96);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // ListBArray
            // 
            this.ListBArray.FormattingEnabled = true;
            this.ListBArray.Location = new System.Drawing.Point(43, 43);
            this.ListBArray.Name = "ListBArray";
            this.ListBArray.Size = new System.Drawing.Size(206, 264);
            this.ListBArray.TabIndex = 1;
            // 
            // ListBMatriz
            // 
            this.ListBMatriz.FormattingEnabled = true;
            this.ListBMatriz.Location = new System.Drawing.Point(584, 51);
            this.ListBMatriz.Name = "ListBMatriz";
            this.ListBMatriz.Size = new System.Drawing.Size(185, 264);
            this.ListBMatriz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matriz";
            // 
            // array37
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBMatriz);
            this.Controls.Add(this.ListBArray);
            this.Controls.Add(this.btnIniciar);
            this.Name = "array37";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ListBox ListBArray;
        private System.Windows.Forms.ListBox ListBMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}