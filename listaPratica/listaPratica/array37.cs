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
    public partial class array37 : Form
    {
        public array37()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string resultVetor="", resultMatriz="";
            string numero;
            double[] vetorA= new double[10];
            double[,] matrizB= new double[1,10];
        for(int i=0;i<10;i++)
            {
                numero = Interaction.InputBox("Digite o dado", "Entrada de Dados");
                if(double.TryParse(numero, out double valor))
                {
                    vetorA[i] = valor;
                    matrizB[0, i] = (i % 2 == 0 ? valor * 5 : valor + 5);

                }
                numero = "";
                
            };
            for(int i = 0; i < 10; i++)
            {
                resultVetor = $"\n vetor [{i}]: {vetorA[i]}";
                ListBArray.Items.Add(resultVetor);
            }
               
            for (int j = 0; j < 10; j++)
            {
                resultMatriz = $"\n matriz [0,{j}]: {matrizB[0, j]}";
                ListBMatriz.Items.Add(resultMatriz);
            }
                
            //ListBArray.Items.Add(resultVetor);
         
            //Lbox.Items.Add(resultado);






        }
    }
}
