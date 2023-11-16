using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaPratica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sequenciaDivisao36_Click(object sender, EventArgs e)
        {
            fracao36 formFracao = new fracao36 ();

            formFracao.WindowState = FormWindowState.Maximized;
            formFracao.Show();
        }

        private void InputVetor37_Click(object sender, EventArgs e)
        {
            array37 formarray = new array37 ();

            formarray.WindowState = FormWindowState.Maximized;
            formarray.Show();
        }

        private void inputboxMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matriz38 formmatriz = new matriz38 ();
            formmatriz.Show();
        }

        private void vagaTrabalhoMenu_Click(object sender, EventArgs e)
        {
            emprego39 forEmprego = new emprego39 ();
            forEmprego.Show();
        }

        private void converterMedidas40_Click(object sender, EventArgs e)
        {
            conversao40 forConversao = new conversao40 (); 
            forConversao.Show();
        }
    }
}
