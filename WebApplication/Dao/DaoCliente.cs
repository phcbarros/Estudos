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
        public IList<ICliente> Listar()
        {
            var lista = new List<ICliente>();
            var sql = new StringBuilder();
            var tabela = new TblClientes();

            sql.AppendFormat(" SELECT DISTINCT {0}, {1}", tabela.Id, tabela.Nome);
            sql.AppendFormat(" FROM {0}", tabela.NomeTabela);
            sql.AppendFormat(" WHERE {0}={1}", tabela.Status_Id, Status.Ativo.GetHashCode());
            sql.AppendFormat(" ORDER BY {0};", tabela.Nome);

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    using (var dr = dal.ExecuteReader(sql.ToString()))
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                Status.Ativo));
                        }
                    }
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return lista;
        }

        public bool Alterar(ICliente model)
        {
            throw new NotImplementedException();
        }

        public ICliente Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Inativar(ICliente model)
        {
            throw new NotImplementedException();
        }

        public int Inserir(ICliente model)
        {
            int retorno;
            var sql = new StringBuilder();
            var tabela = new TblClientes();

            sql.AppendFormat(" INSERT INTO {0} ({1},{2})", tabela.NomeTabela, tabela.Nome, tabela.Status_Id);
            sql.Append(" VALUES (@nome,@status_id);");
            
            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametro("nome", SqlDbType.Char, model.Nome);
                    dal.CriarParametro("status_id", SqlDbType.SmallInt, model.Status.GetHashCode());

                    dal.ExecuteNonQuery(sql.ToString());
                    retorno = Convert.ToInt32(dal.UltimoIdInserido);
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return retorno;
        }
    }
}