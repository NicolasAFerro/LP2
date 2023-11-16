using Microsoft.VisualBasic;
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
    public partial class matriz38 : Form
    {
        public matriz38()
        {
            InitializeComponent();
        }
        string saida = "";
        string entrada = ""; 
        double[,] compras=new double[7,5];
        double[] totalDia = new double[7];
        double soma = 0, totalGeral = 0;

      

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    entrada = Interaction.InputBox("Insira o valor: ");
                    if(!double.TryParse(entrada, out compras[i,j]))
                    {
                        MessageBox.Show("dado incorreto");
                        i--; j--;
                    }
                }
                

            }
            for(int i = 0;i < 7; i++)
            {
                soma = 0;
                for(int j = 0; j < 5; j++)
                {
                    soma += compras[i, j];
                }
                totalDia[i] = soma;
                totalGeral+= soma;
            }
            for(int i = 0;i<7 ; i++)
            {
               
                saida =$"\ntotal dia[{i + 1}]:{totalDia[i]}";
                ListBresultado.Items.Add(saida);
                saida = "";
            }
            saida = $"\ntotal geral: {totalGeral}";
            ListBresultado.Items.Add(saida);
            btnLimpar.Focus();

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ListBresultado.Items.Clear();
            saida = "";
            entrada = "";
            soma = 0; totalGeral = 0;
            btnIniciar.Focus();

        }
    }
}
