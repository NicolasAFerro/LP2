using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdespesas0030482313036
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }
    }
}
