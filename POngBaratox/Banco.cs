using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox
{
    internal class Banco
    {
        string Conexao = "Data Source = localhost; Initial Catalog = ONG; User Id = sa; Password = Tricolor2511;";

        public Banco()
        {

        }
        public string Caminho()
        {
            return Conexao;
        }

        public SqlConnection OpenConexao()
        {
            Banco conn = new Banco();
            SqlConnection conexaosql = new SqlConnection(conn.Caminho());
            conexaosql.Open();
            return conexaosql;
        }

        public SqlConnection CloseConexao()
        {
            Banco conn = new Banco();
            SqlConnection conexaosql = new SqlConnection(conn.Caminho());
            conexaosql.Close();
            return conexaosql;
        }
    }
}
