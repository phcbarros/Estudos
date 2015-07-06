using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebGrease.Css.Extensions;

namespace WebApplication.Infraestrutura.SqlServer
{
    public class DalHelperSqlServer : IDisposable
    {
        private SqlConnection Conexao { get; set; }
        private ICollection<SqlParameter> Parametros { get; set; }
        public int UltimoIdInserido { get; private set; }
        public DalHelperSqlServer()
        {
            Conexao = ConexaoSqlServer.GetConnection();
        }
        public void CriarParametro(string nome, SqlDbType tipo, object valor)
        {
            var parametro = new SqlParameter(nome, tipo);

            if (valor == null)
            {
                parametro.Value = DBNull.Value;
            }
            else
            {
                parametro.Value = valor;
            }

            Parametros = Parametros ?? new List<SqlParameter>();

            Parametros.Add(parametro);
        }
        private SqlCommand CriarComando(string sql)
        {
            var comando = new SqlCommand(sql, Conexao);
            if (Parametros != null && Parametros.Count > 0)
            {
                Parametros.ForEach(parameter => comando.Parameters.Add(parameter));
            }
            return comando;
        }
        /// <exception cref="MySqlException"></exception>
        public int ExecuteNonQuery(string sql)
        {
            int retorno;
            using (var comando = CriarComando(sql))
            {
                comando.Connection.Open();
                using (var transacao = Conexao.BeginTransaction(IsolationLevel.Serializable))
                {
                    comando.Transaction = transacao;
                    try
                    {
                        retorno = comando.ExecuteNonQuery();
                        transacao.Commit();
                        UltimoIdInserido = Convert.ToInt32(this.ExecuteScalar("SELECT SCOPE_IDENTITY() AS LastInsertedId;"));
                    }
                    catch (SqlException exception)
                    {
                        try
                        {
                            transacao.Rollback();
                            throw;
                        }
                        catch (InvalidOperationException)
                        {
                            throw exception;
                        }
                    }
                }
            }
            return retorno;
        }
        /// <exception cref="MySqlException"></exception>
        public object ExecuteScalar(string sql)
        {
            object objeto;
            using (var comando = CriarComando(sql))
            {
                comando.Connection.Open();
                objeto = comando.ExecuteScalar();
            }
            return objeto;
        }
        /// <exception cref="MySqlException"></exception>
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader dr;
            using (var comando = CriarComando(sql))
            {
                comando.Connection.Open();
                dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            }
            return dr;
        }
        /// <exception cref="MySqlException"></exception>
        public void Dispose()
        {
            Conexao.Close();
            Conexao.Dispose();
        }
    }
}
