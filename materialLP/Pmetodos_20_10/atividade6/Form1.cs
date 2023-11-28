using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("funcionou copiar");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("funcionou colar");
        }
        // para não ficar voando, colocar o primeiro como container isMDIContainer
        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExerc3>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                Application.OpenForms["frmExerc3"].Activate();
            }
            else
            {
                frmExerc3 obj3 = new frmExerc3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void Exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmExerc4>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                Application.OpenForms["frmExerc4"].Activate();
            }
            else
            {
                frmExerc4 obj4 = new frmExerc4 ();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }

        }

        private void Exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmExerc5>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                Application.OpenForms["frmExerc4"].Activate();
            }
            else
            {
                frmExerc5 obj5 = new frmExerc5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Maximized;
                obj5.Show();
            }

        }
    }
}
