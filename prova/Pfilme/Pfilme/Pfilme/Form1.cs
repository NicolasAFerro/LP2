using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pfilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] matrizFilme = new double[6, 2];
        double nota, mediaFilme1 = 0, mediaFilme2 = 0;
        string textoInput, resultado, resultado2;
        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 2; j++)
                {
                    textoInput = Interaction.InputBox($" Pessoa {i + 1 } digite a nota do filme {j + 1}");

                    if (!double.TryParse(textoInput, out nota))
                    {
                        MessageBox.Show("valor inválido");
                        j--;

                    }
                    else if (nota < 0 || nota > 10)
                        MessageBox.Show("numero deve estar entre 0 e 10");
                    else
                    {
                        matrizFilme[i, j] = nota;

                    }
                }
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 1; j++)
                {
                    resultado = $" Pessoa {i+1} Nota filme 1: {matrizFilme[i, 0]} nota filme 2:{matrizFilme[i,1]}\n";
                    ListBoxResultado.Items.Add(resultado);
                 
                }
           for(int i = 0; i < 6; i++)
            {
                mediaFilme1 += matrizFilme[i, 0];
                mediaFilme2 += matrizFilme[i, 1];
            }
            mediaFilme1 = mediaFilme1/6;
            mediaFilme2 = mediaFilme2/6;
            resultado2 += $"----------------------------------------------\n";
            ListBoxResultado.Items.Add(resultado2);
            resultado2 = $"media filme 1: {mediaFilme1} \n";
            ListBoxResultado.Items.Add(resultado2);
            resultado2 = $"media filme 2: {mediaFilme2} \n";
            ListBoxResultado.Items.Add(resultado2);

        }
    }
}

