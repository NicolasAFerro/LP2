namespace listaPratica
{
    partial class emprego39
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBestadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnViuvo = new System.Windows.Forms.RadioButton();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.radioButtonOutros = new System.Windows.Forms.RadioButton();
            this.ckbSexo = new System.Windows.Forms.CheckBox();
            this.groupBSexo = new System.Windows.Forms.GroupBox();
            this.checkBfeminino = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDistancia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbUltimaEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTempoExperiencia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskBSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.groupBestadoCivil.SuspendLayout();
            this.groupBSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(111, 65);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.Validated += new System.EventHandler(this.txtTelefone_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.comboBox1.Location = new System.Drawing.Point(111, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // groupBestadoCivil
            // 
            this.groupBestadoCivil.Controls.Add(this.rbtnSolteiro);
            this.groupBestadoCivil.Controls.Add(this.rbtnCasado);
            this.groupBestadoCivil.Controls.Add(this.rbtnViuvo);
            this.groupBestadoCivil.Controls.Add(this.rbtnDivorciado);
            this.groupBestadoCivil.Controls.Add(this.radioButtonOutros);
            this.groupBestadoCivil.Location = new System.Drawing.Point(281, 12);
            this.groupBestadoCivil.Name = "groupBestadoCivil";
            this.groupBestadoCivil.Size = new System.Drawing.Size(251, 246);
            this.groupBestadoCivil.TabIndex = 7;
            this.groupBestadoCivil.TabStop = false;
            this.groupBestadoCivil.Text = "Estado Civil";
            this.groupBestadoCivil.Validated += new System.EventHandler(this.groupBestadoCivil_Validated);
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(15, 38);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rbtnSolteiro.TabIndex = 12;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(15, 79);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtnCasado.TabIndex = 8;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnViuvo
            // 
            this.rbtnViuvo.AutoSize = true;
            this.rbtnViuvo.Location = new System.Drawing.Point(15, 116);
            this.rbtnViuvo.Name = "rbtnViuvo";
            this.rbtnViuvo.Size = new System.Drawing.Size(52, 17);
            this.rbtnViuvo.TabIndex = 9;
            this.rbtnViuvo.TabStop = true;
            this.rbtnViuvo.Text = "Viuvo";
            this.rbtnViuvo.UseVisualStyleBackColor = true;
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Location = new System.Drawing.Point(15, 150);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rbtnDivorciado.TabIndex = 10;
            this.rbtnDivorciado.TabStop = true;
            this.rbtnDivorciado.Text = "Divorciado";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutros
            // 
            this.radioButtonOutros.AutoSize = true;
            this.radioButtonOutros.Location = new System.Drawing.Point(15, 190);
            this.radioButtonOutros.Name = "radioButtonOutros";
            this.radioButtonOutros.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOutros.TabIndex = 11;
            this.radioButtonOutros.TabStop = true;
            this.radioButtonOutros.Text = "Outros";
            this.radioButtonOutros.UseVisualStyleBackColor = true;
            // 
            // ckbSexo
            // 
            this.ckbSexo.AutoSize = true;
            this.ckbSexo.Checked = true;
            this.ckbSexo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSexo.Location = new System.Drawing.Point(6, 29);
            this.ckbSexo.Name = "ckbSexo";
            this.ckbSexo.Size = new System.Drawing.Size(74, 17);
            this.ckbSexo.TabIndex = 8;
            this.ckbSexo.Text = "Masculino";
            this.ckbSexo.UseVisualStyleBackColor = true;
            // 
            // groupBSexo
            // 
            this.groupBSexo.Controls.Add(this.checkBfeminino);
            this.groupBSexo.Controls.Add(this.ckbSexo);
            this.groupBSexo.Location = new System.Drawing.Point(558, 12);
            this.groupBSexo.Name = "groupBSexo";
            this.groupBSexo.Size = new System.Drawing.Size(200, 114);
            this.groupBSexo.TabIndex = 9;
            this.groupBSexo.TabStop = false;
            this.groupBSexo.Text = "Sexo";
            // 
            // checkBfeminino
            // 
            this.checkBfeminino.AutoSize = true;
            this.checkBfeminino.Location = new System.Drawing.Point(6, 73);
            this.checkBfeminino.Name = "checkBfeminino";
            this.checkBfeminino.Size = new System.Drawing.Size(68, 17);
            this.checkBfeminino.TabIndex = 9;
            this.checkBfeminino.Text = "Feminino";
            this.checkBfeminino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distancia";
            // 
            // comboBoxDistancia
            // 
            this.comboBoxDistancia.FormattingEnabled = true;
            this.comboBoxDistancia.Items.AddRange(new object[] {
            "0 até 20 KM",
            "21 até 50 KM",
            "51 a 100KM",
            "maior que 100KM. "});
            this.comboBoxDistancia.Location = new System.Drawing.Point(111, 176);
            this.comboBoxDistancia.Name = "comboBoxDistancia";
            this.comboBoxDistancia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistancia.TabIndex = 12;
            this.comboBoxDistancia.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistancia_SelectedIndexChanged);
            this.comboBoxDistancia.Validated += new System.EventHandler(this.comboBoxDistancia_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Última Empresa";
            // 
            // txtbUltimaEmpresa
            // 
            this.txtbUltimaEmpresa.Location = new System.Drawing.Point(111, 224);
            this.txtbUltimaEmpresa.Name = "txtbUltimaEmpresa";
            this.txtbUltimaEmpresa.Size = new System.Drawing.Size(121, 20);
            this.txtbUltimaEmpresa.TabIndex = 14;
            this.txtbUltimaEmpresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtbUltimaEmpresa_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tempo de Experiência";
            // 
            // comboBoxTempoExperiencia
            // 
            this.comboBoxTempoExperiencia.FormattingEnabled = true;
            this.comboBoxTempoExperiencia.Items.AddRange(new object[] {
            "até 1 ano ",
            "1 a 2 anos ",
            "2 a 3 anos ",
            "3 a 5 anos ",
            "mais que 5 anos"});
            this.comboBoxTempoExperiencia.Location = new System.Drawing.Point(131, 275);
            this.comboBoxTempoExperiencia.Name = "comboBoxTempoExperiencia";
            this.comboBoxTempoExperiencia.Size = new System.Drawing.Size(101, 21);
            this.comboBoxTempoExperiencia.TabIndex = 16;
            this.comboBoxTempoExperiencia.Validated += new System.EventHandler(this.comboBoxTempoExperiencia_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salário Pretendido";
            // 
            // mskBSalario
            // 
            this.mskBSalario.Location = new System.Drawing.Point(131, 326);
            this.mskBSalario.Mask = "00000.00";
            this.mskBSalario.Name = "mskBSalario";
            this.mskBSalario.Size = new System.Drawing.Size(100, 20);
            this.mskBSalario.TabIndex = 18;
            this.mskBSalario.Validated += new System.EventHandler(this.mskBSalario_Validated);
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.Location = new System.Drawing.Point(573, 275);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(185, 142);
            this.btnCandidatar.TabIndex = 19;
            this.btnCandidatar.Text = "Candidatar-se";
            this.btnCandidatar.UseVisualStyleBackColor = true;
            this.btnCandidatar.Click += new System.EventHandler(this.btnCandidatar_Click);
            // 
            // emprego39
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 482);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.mskBSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTempoExperiencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbUltimaEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBSexo);
            this.Controls.Add(this.groupBestadoCivil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "emprego39";
            this.Text = "Form3";
            this.groupBestadoCivil.ResumeLayout(false);
            this.groupBestadoCivil.PerformLayout();
            this.groupBSexo.ResumeLayout(false);
            this.groupBSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBestadoCivil;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnViuvo;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private System.Windows.Forms.RadioButton radioButtonOutros;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.CheckBox ckbSexo;
        private System.Windows.Forms.GroupBox groupBSexo;
        private System.Windows.Forms.CheckBox checkBfeminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbUltimaEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTempoExperiencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskBSalario;
        private System.Windows.Forms.Button btnCandidatar;
    }
}