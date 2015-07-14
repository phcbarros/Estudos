using WebApplication.Dao.Interfaces.Logs;
using WebApplication.Models.Interfaces.Logs;
using WebApplication.Models.Interfaces;
using System.Text;
using WebApplication.Dao.Tabelas;
using System.Data;
using System.Data.SqlClient;
using WebApplication.Infraestrutura.SqlServer;
using WebApplication.Models.Exceptions;

namespace WebApplication.Dao.Logs
{
    public class DaoClienteLog : IDaoClienteLog
    {
        #region Inserir
        /// <exception cref="MyException"></exception>
        public void Inserir(ICliente cliente, ILog log)
        {
            var sql = new StringBuilder();
            var tblClientes = new TblClientes();

            sql.AppendFormat(" INSERT INTO {0} ({1},{2})", tblClientes.NomeTabela, tblClientes.Nome, tblClientes.Status_Id);
            sql.Append(" VALUES (@nome,@status_id);");

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametro("nome", SqlDbType.Char, cliente.Nome);
                    dal.CriarParametro("status_id", SqlDbType.SmallInt, cliente.Status.GetHashCode());

                    dal.ExecuteNonQuery(sql.ToString());
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }
        }
        #endregion
    }
}