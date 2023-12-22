using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Windows.Forms;
using System.ComponentModel;

namespace FacoQuaseTudo
{
    internal class Servico
    {
        public int IdServico { get; set; }
        public double ValorServico { get; set; }
        public DateTime DataServico { get; set; }
        public string Observacao { get; set; }
        public int Tipo_IdTipo { get; set; } 

        public int Incluir()
        {
            int returno = 0;
            try
            {
               /* Declaração de uma variável mycommand do tipo SqlCommand. 
                Este objeto será usado para executar comandos SQL no banco de dados.*/
               SqlCommand mycommand; 
               mycommand = new SqlCommand();// precisa ter a conexão com o banco no load do Main;  

               //Criação de um novo objeto SqlCommand com uma instrução SQL INSERT
               mycommand = new SqlCommand("INSERT INTO Servicos VALUES (@ValorServico,@DataServico,@Observacao," +
                     "@Tipo_IdTipo)", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ValorServico", SqlDbType.Decimal));
                mycommand.Parameters.Add(new SqlParameter("@DataServico", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)); 
                mycommand.Parameters.Add(new SqlParameter("Tipo_IdTipo", SqlDbType.Int));
                mycommand.Parameters["@ValorServico"].Value = ValorServico;
                mycommand.Parameters["@DataServico"].Value = DataServico;
                mycommand.Parameters["@Observacao"].Value = Observacao;
                mycommand.Parameters["@Tipo_IdTipo"].Value = Tipo_IdTipo; 
                mycommand.ExecuteNonQuery();


            /*Adição de Parâmetros: O método adiciona quatro parâmetros ao comando SQL, correspondendo aos campos da tabela "DESPESA" 
            (@valordespesa, @datadespesa, @obsdespesa, @tipo_idtipo), cada um com um tipo de dado específico.

            Atribuição de Valores aos Parâmetros: Os valores das propriedades da instância da classe 
                    (Valordespesa, Datadespesa, Obsdespesa, Tipo_idtipo) são atribuídos aos parâmetros do comando SQL.*/
            }
            catch (Exception ex)
            {
                throw;
            }
            return returno;
        }
    }
}
