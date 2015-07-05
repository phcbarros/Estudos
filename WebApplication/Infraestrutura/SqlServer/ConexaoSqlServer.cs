using System.Data.SqlClient;

namespace WebApplication.Infraestrutura.SqlServer
{
    public class ConexaoSqlServer
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"server=JESSÉ\SQLEXPRESS;database = Estudos_Dao; Trusted_Connection=Yes;");
        }
    }
}
