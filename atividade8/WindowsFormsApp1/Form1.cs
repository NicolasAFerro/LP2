using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//LEMBRAR DE IMPORTAR 
//ADICIONAR : PROJETO>REFERENCIA

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] vetorNum = new int[20];
            //INPUT BOX 
            string saida = "";
            string auxiliar = "";               //parte de baixo    //Titulo
            for (var i =0; i<20; i++)
            {
                auxiliar = Interaction.InputBox($"Digite número {i++}º", "Entrada de Dados");
                if (auxiliar == "")
                    return;// sai de todo o evento 
                if(!int.TryParse(auxiliar, out vetorNum[i]))
                {
                    MessageBox.Show("valor inválido");
                    i--;
                }
                else
                {
                    saida =vetorNum[i]+"\n"+saida;
                }
            }
            MessageBox.Show(saida);

            //REVERSE 
            Array.Reverse(vetorNum);
            auxiliar = "";
            foreach(var x in vetorNum)
            {
                auxiliar += x+"\n";
                

            }
            MessageBox.Show(auxiliar);
            //for ao contrario 
            auxiliar = "";
            for(var x = 19; x >= 0; x--)
            {
                auxiliar += vetorNum[x] + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           // matriz é linha dps coluna
            double[,] vetorNotas= new double[20,3];
            double[] medias = new double[20];
            string auxiliar = "";
            for(int i=0;i<20;i++)
                for(int j = 0; j < 3; j++)
                {
                    auxiliar=Interaction.InputBox($"Digite a nota {j+1}º para o aluno{i+1}", "Entrada de Dados");
                    if (!Double.TryParse(auxiliar, out vetorNotas[i, j]))
                    {
                        MessageBox.Show("valor inválido");
                        j--;
                    }
                    else
                        if(vetorNotas[i, j]<0|| vetorNotas[i, j] > 10)
                    {
                        MessageBox.Show("valor inválido");
                        j--;
                    }
                      

                }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    medias[i] = medias[i]+ vetorNotas[i,j];
                }
                medias[i] = medias[i] / 3;
            }
            string saida = "";
            for (var x =0; x<20; x++)
            {
                saida += $"Aluno {x+ 1}: {medias[x]:F2}\n";
            }
            //for (var x = 0; x < 20; x++)
                MessageBox.Show(saida);


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show(Total.ToString());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ArrayList alunos =new ArrayList() { "Ana","André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            alunos.Remove("Otávio");
            string novaSaida = ""; 
            foreach(var x in alunos)
            {
                novaSaida+=x.ToString()+"; \n";
            }
            MessageBox.Show(novaSaida);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
          

           Form2 form2 = new Form2();
           form2.Show();
        }
    }
}
