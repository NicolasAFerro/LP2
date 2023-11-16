using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pdespesas0030482313036
{
    internal class Despesa
    {
        //prop e dois tabs 
        public int Iddespesa { get; set; }
        public double Valordespesa { get; set; } 
        public DateTime Datadespesa { get; set; }
        public string Obsdespesa { get; set; }
        public int Tipo_idtipo { get; set; }


        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;

            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA", FormPrincipal.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception)
            {
                throw;
            }
            return dtDespesa;
        }
        public int Incluir() // INCLUSAO
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES (@valordespesa,@datadespesa,@obsdespesa," +
                "@tipo_idtipo)", FormPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@valordespesa", SqlDbType.Decimal));
                mycommand.Parameters.Add(new SqlParameter("@datadespesa", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@obsdespesa", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@tipo_idtipo", SqlDbType.Int));
                mycommand.Parameters["@valordespesa"].Value = Valordespesa;
                mycommand.Parameters["@datadespesa"].Value = Datadespesa;
                mycommand.Parameters["@obsdespesa"].Value = Obsdespesa;
                mycommand.Parameters["@tipo_idtipo"].Value = Tipo_idtipo;
                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        public int Alterar() // alteração
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE DESPESA SET VALORDESPESA=@valordespesa,DATADESPESA=@datadespesa," +
                "OBSDESPESA=@obsdespesa,TIPO_IDTIPO =@tipo_idtipo WHERE IDDESPESA = @iddespesa", FormPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@iddespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@valordespesa", SqlDbType.Decimal));
                mycommand.Parameters.Add(new SqlParameter("@datadespesa", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@obsdespesa", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@tipo_idtipo", SqlDbType.Int));

                mycommand.Parameters["@iddespesa"].Value = Iddespesa;
                mycommand.Parameters["@valordespesa"].Value = Valordespesa;
                mycommand.Parameters["@datadespesa"].Value = Datadespesa;
                mycommand.Parameters["@obsdespesa"].Value = Obsdespesa;
                mycommand.Parameters["@tipo_idtipo"].Value = Tipo_idtipo;

                retorno = mycommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public int Excluir() // EXCLUSÃO
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM DESPESA WHERE IDDESPESA=@iddespesa", FormPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@iddespesa", SqlDbType.Int));
                mycommand.Parameters["@iddespesa"].Value = Iddespesa;

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }

            return nReg;
        }
    }
}
