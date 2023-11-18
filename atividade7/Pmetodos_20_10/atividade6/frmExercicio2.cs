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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {//true ignora case sensitive
            if (String.Compare(txtb1.Text, txtb2.Text, true) == 0)
            {
                MessageBox.Show("são iguais");
            }
            else
            {
                MessageBox.Show("são diferentes");
            }
        }

        private void Btninserir1_Click(object sender, EventArgs e)
        {
            int metade =txtb2.Text.Length / 2;

            txtb2.Text = txtb2.Text.Substring(0, metade) + txtb1.Text + txtb2.Text.Substring(metade, txtb2.Text.Length - metade);
        }

        private void BtnInserir2_Click(object sender, EventArgs e)
        {
            int metade = txtb1.Text.Length / 2;
            txtb2.Text = txtb1.Text.Insert(metade, "**");

        }
    }
}
