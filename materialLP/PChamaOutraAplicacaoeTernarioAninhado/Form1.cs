using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PChamaOutraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dependendo do caso precisa inserir a pasta de destino antes do nome do programa
            Process.Start("Calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mediaAluno = 8;
            string resultado = "";

            resultado =  mediaAluno >= 7 ? "aprovado." : (mediaAluno >=3 ? "exame" : "reprovado");
            MessageBox.Show(resultado);

            mediaAluno = 3;
            resultado = mediaAluno >= 7 ? "aprovado." : (mediaAluno >= 3 ? "exame" : "reprovado");
            MessageBox.Show(resultado);
        }
    }
}