using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int[] tamanhoSemEspaco = new int[6];
        int cont = 0;
        string[] nomes = new string[6];
        string resultado = "";

        public Form2()
        {
            InitializeComponent();
        }
       
        

        private void btnInicio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                nomes[i] = Interaction.InputBox($"Insira o {i + 1}º nome");
                foreach(char c in nomes[i])
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        MessageBox.Show("nome inválido");
                        i--;
                    }
                        
                }
            }

            for (var x = 0; x < 6; x++)
            {
                tamanhoSemEspaco[x] = nomes[x].Length;
                cont = 0;
                for (int i = 0; i < nomes[x].Length; i++)
                {
                    if (char.IsWhiteSpace(nomes[x][i]))
                    {
                        cont++;
                        tamanhoSemEspaco[x] -= cont;
                    }
                }

            }
           /* resultado = "";
            for (int i = 0; i < 6; i++)
            {
                resultado += $"\no nome: {nomes[i]} tem {tamanhoSemEspaco[i]}  letras";

            }*/
            btnExecutar.Focus();
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
         
            resultado = "";           
            for(int i = 0; i < 6; i++)
            {
                resultado = $"\no nome: {nomes[i]} tem {tamanhoSemEspaco[i]}  letras";
                Lbox.Items.Add(resultado);

            }
               

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Lbox.Items.Clear(); 
            btnInicio.Focus();
        }
    }
}
