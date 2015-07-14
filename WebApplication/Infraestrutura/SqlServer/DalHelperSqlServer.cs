using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebGrease.Css.Extensions;

namespace WebApplication.Infraestrutura.SqlServer
{
    public sealed class DalHelperSqlServer : IDisposable
    {
        #region Propriedades
        private SqlConnection Conexao { get; set; }
        private ICollection<SqlParameter> Parametros { get; set; }
        #endregion

        #region Construtores
        public DalHelperSqlServer()
        {
            Conexao = ConexaoSqlServer.GetConnection();
        }
        #endregion

        #region Criar Parâmetros e Comando
        public void CriarParametro(string nome, SqlDbType tipo, object valor, ParameterDirection direction = ParameterDirection.Input)
        {
            var parametro = new SqlParameter(nome, tipo);
            parametro.Direction = direction;

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
        #endregion

        #region Alterar Inativar Inativar
        /// <exception cref="SqlException"></exception>
        public int ExecuteNonQuery(string sql)
        {
            int retorno;
            using (var comando = CriarComando(sql))
            {
                AbrirConexao(comando);
                using (var transacao = Conexao.BeginTransaction(IsolationLevel.Serializable))
                {
                    comando.Transaction = transacao;
                    try
                    {
                        retorno = comando.ExecuteNonQuery();
                        transacao.Commit();
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
        #endregion

        #region Consultar
        /// <exception cref="SqlException"></exception>
        public object ExecuteScalar(string sql)
        {
            object objeto;
            using (var comando = CriarComando(sql))
            {
                AbrirConexao(comando);
                objeto = comando.ExecuteScalar();
            }
            return objeto;
        }
        #endregion

        #region Consultar Listar
        /// <exception cref="SqlException"></exception>
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader dr;
            using (var comando = CriarComando(sql))
            {
                AbrirConexao(comando);
                dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            }
            return dr;
        }
        #endregion

        #region Abrir e Fechar Conexão
        /// <exception cref="SqlException"></exception>
        private void AbrirConexao(SqlCommand comando)
        {
            if (comando.Connection.State != ConnectionState.Open)
            {
                comando.Connection.Open();
            }
        }

        /// <exception cref="SqlException"></exception>
        public void Dispose()
        {
            Conexao.Close();
            Conexao.Dispose();
        }
        #endregion
    }
}
