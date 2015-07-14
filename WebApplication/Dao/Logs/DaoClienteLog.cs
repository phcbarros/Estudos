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
            var tblLog = new TblClientesLog();

            sql.AppendFormat(" INSERT INTO {0} ({1},{2},{3}", tblLog.NomeTabela, tblLog.Clientes_Id, tblLog.Clientes_Nome, tblLog.Clientes_Status_Id);
            sql.AppendFormat(",{0},{1},{2})", tblLog.Usuarios_Id, tblLog.Operacao_Id, tblLog.DataHora);
            sql.Append(" VALUES (@id,@nome,@status_id");
            sql.Append(",@usuarios_id,@operacao_id,@datahora);");

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametro("id", SqlDbType.Int, cliente.Id);
                    dal.CriarParametro("nome", SqlDbType.Char, cliente.Nome);
                    dal.CriarParametro("status_id", SqlDbType.SmallInt, cliente.Status.GetHashCode());
                    dal.CriarParametro("usuarios_id", SqlDbType.Int, log.Usuario.Id);
                    dal.CriarParametro("operacao_id", SqlDbType.SmallInt, log.Operacao.GetHashCode());
                    dal.CriarParametro("datahora", SqlDbType.DateTime, log.DataHora);

                    dal.ExecuteNonQuery(sql.ToString());
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }
        }
        #endregion
    }
}