using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pdespesas0030482313036
{
    class Tipo
    {
        //atributos
        private int idtipo;
        private string descricaoTipo;

        //propriedades 
        public int Idtipo// assim eu consigo validar , da forma curta na despesa;
        {
            get { return idtipo; }
            set { idtipo = value; }
        }
        public string DescricaoTipo
        {
            get { return descricaoTipo;} 
            set { descricaoTipo = value; }
        }
        public DataTable Listar() //metodo
        {
            SqlDataAdapter daTipo;

            DataTable dtTipo = new DataTable();

            try
            {
                daTipo = new SqlDataAdapter("SELECT * FROM TIPO", FormPrincipal.conexao);
                daTipo.Fill(dtTipo);
                daTipo.FillSchema(dtTipo, SchemaType.Source);
            }
            catch (Exception)
            {
                throw; //levantar uma exceção
            }
            return dtTipo;
        }
    }
}
