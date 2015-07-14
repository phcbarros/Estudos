using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WebApplication.Dao.Interfaces;
using WebApplication.Dao.Tabelas;
using WebApplication.Infraestrutura.SqlServer;
using WebApplication.Models;
using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao
{
    public sealed class DaoCliente : IDaoCliente
    {
        #region Alterar
        /// <exception cref="MyException"></exception>
        public bool Alterar(ICliente cliente)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Consultar
        /// <exception cref="MyException"></exception>
        public ICliente Consultar(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inativar
        /// <exception cref="MyException"></exception>
        public bool Inativar(ICliente cliente)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inserir
        /// <exception cref="MyException"></exception>
        public int Inserir(ICliente cliente)
        {
            int retorno;
            var sql = new StringBuilder();
            var tblClientes = new TblClientes();

            sql.AppendFormat(" INSERT INTO {0} ({1},{2})", tblClientes.NomeTabela, tblClientes.Nome, tblClientes.Status_Id);
            sql.Append(" VALUES (@nome,@status_id);");
            sql.Append(" SET @id=SCOPE_IDENTITY();");

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametroDeEntrada("nome", SqlDbType.Char, cliente.Nome);
                    dal.CriarParametroDeEntrada("status_id", SqlDbType.SmallInt, cliente.Status.GetHashCode());
                    var parametroDeSaida = dal.CriarParametroDeSaida("id", SqlDbType.Int);

                    dal.ExecuteNonQuery(sql.ToString());
                    retorno = Convert.ToInt32(parametroDeSaida.Value);
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return retorno;
        }

        /// <exception cref="MyException"></exception>
        public bool ExisteNomenclaturaInformada(ICliente cliente)
        {
            bool resultado;
            var sql = new StringBuilder();
            var tblClientes = new TblClientes();

            sql.AppendFormat(" SELECT {0}", tblClientes.Id);
            sql.AppendFormat(" FROM {0}", tblClientes.NomeTabela);
            sql.AppendFormat(" WHERE {0}=@nome;", tblClientes.Nome);

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametroDeEntrada("nome", SqlDbType.Char, cliente.Nome);

                    resultado = Convert.ToBoolean(dal.ExecuteScalar(sql.ToString()));//Null ou 0 (Zero) = False; > 0 (Zero) = True;
                }
                catch (SqlException)
                { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return resultado;
        }
        #endregion

        #region Listar
        /// <exception cref="MyException"></exception>
        public IList<ICliente> Listar()
        {
            var clientes = new List<ICliente>();
            var sql = new StringBuilder();
            var tblClientes = new TblClientes();

            sql.AppendFormat(" SELECT DISTINCT {0}, {1}", tblClientes.Id, tblClientes.Nome);
            sql.AppendFormat(" FROM {0}", tblClientes.NomeTabela);
            sql.AppendFormat(" WHERE {0}={1}", tblClientes.Status_Id, Status.Ativo.GetHashCode());
            sql.AppendFormat(" ORDER BY {0};", tblClientes.Nome);

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    using (var dr = dal.ExecuteReader(sql.ToString()))
                    {
                        while (dr.Read())
                        {
                            clientes.Add(new Cliente(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                Status.Ativo));
                        }
                    }
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return clientes;
        }
        #endregion
    }
}