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
    public sealed class DaoUnidade : IDaoUnidade
    {
        public IList<IUnidade> Listar(ICliente model)
        {
            var lista = new List<IUnidade>();
            var sql = new StringBuilder();
            var tabela = new TblUnidades();

            sql.AppendFormat(" SELECT DISTINCT {0}, {1}", tabela.Id, tabela.Nome);
            sql.AppendFormat(" FROM {0}", tabela.NomeTabela);
            sql.AppendFormat(" WHERE {0}=@id", tabela.Clientes_Id);
            sql.AppendFormat(" AND {0}={1}", tabela.Status_Id, Status.Ativo.GetHashCode());
            sql.AppendFormat(" ORDER BY {0};", tabela.Nome);

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametro("id", SqlDbType.Int, model.Id);
                    using (var dr = dal.ExecuteReader(sql.ToString()))
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Unidade(
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

        public bool Alterar(IUnidade model)
        {
            throw new NotImplementedException();
        }

        public IUnidade Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Inativar(IUnidade model)
        {
            throw new NotImplementedException();
        }

        public int Inserir(IUnidade model)
        {
            throw new NotImplementedException();
        }
    }
}