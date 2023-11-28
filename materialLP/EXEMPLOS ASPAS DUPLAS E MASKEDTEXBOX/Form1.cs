using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringona = "\"como adicionar aspas duplas\"";
           
            
            MessageBox.Show(stringona);

            string stringona2 = "teste de aspas duplas"; // 21 caracteres

            MessageBox.Show(stringona2.PadLeft(50)); //50-21= 29 caracteres em branco a esquerda
            MessageBox.Show(stringona2.PadLeft(50, '*')); // 29 asteriscos a esquerda
            MessageBox.Show(stringona2.PadLeft(50, '"'));// 29 aspas duplas a esquerda

        }
  private void mskbxValor_Leave(object sender, EventArgs e)
        {
            // os tamanhos aqui consideram que a máscara utilizada
            // foi 999999.99 --> 8 caracteres

            // limpa as literais
            mskbxValor1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
             mskbxValor1.Text = mskbxValor1.Text.PadRight(8, '0');
            mskbxValor1.Text = mskbxValor1.Text.Trim().PadLeft(8, '0');
            // volta as literais
            mskbxValor1.TextMaskFormat = MaskFormat.IncludeLiterals;
        }


        // Um delegate é um elemento da linguagem C# que permite que você faça referência a um método. 
        //   Então um delegate em C#, é semelhante a um ponteiro de função (a vantagem é que é um ponteiro seguro).
        //  Usando um delegate você pode encapsular a referência a um método dentro de um objeto de delegação.

        public delegate void ChamaDelegate();


        public void Posiciona()
        {
            mskbxValor2.SelectionStart = 7;
            mskbxValor2.SelectionLength = 2;

        }

        private void mskbxValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // os tamanhos aqui consideram que a máscara utilizada
            // foi 999999.99 --> 8 caracteres

           if (e.KeyChar=='.')
            {
                // limpa as literais
                mskbxValor2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                
                int auxiliar = mskbxValor2.Text.Trim().Length; // quantos preenchidos
                mskbxValor2.Text = mskbxValor2.Text.Trim().PadLeft(6, '0');
                auxiliar = mskbxValor2.Text.Trim().Length;
                mskbxValor2.Text = mskbxValor2.Text.PadRight(auxiliar+3, '0');
                // volta as literais


                //Executa um delegate de forma assíncrona no 
                //thread em que o identificador subjacente do controle foi criado.

                mskbxValor2.BeginInvoke(new ChamaDelegate(Posiciona));

                mskbxValor2.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

        }
    }
}
