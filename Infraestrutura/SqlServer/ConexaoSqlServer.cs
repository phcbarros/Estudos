using System.Data.SqlClient;

namespace Infraestrutura.SqlServer
{
    public class ConexaoSqlServer
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"server=JESSÉ\SQLEXPRESS;database = Estudos; Trusted_Connection=Yes;");
        }
    }
}
