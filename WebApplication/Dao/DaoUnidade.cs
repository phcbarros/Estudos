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
        #region Alterar
        /// <exception cref="MyException"></exception>
        public bool Alterar(IUnidade unidade)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Consultar
        /// <exception cref="MyException"></exception>
        public IUnidade Consultar(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inativar
        /// <exception cref="MyException"></exception>
        public bool Inativar(IUnidade unidade)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inserir
        /// <exception cref="MyException"></exception>
        public int Inserir(IUnidade unidade)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Listar
        /// <exception cref="MyException"></exception>
        public IList<IUnidade> Listar(ICliente cliente, Status status)
        {
            var unidades = new List<IUnidade>();
            var sql = new StringBuilder();
            var tblUnidades = new TblUnidades();

            sql.AppendFormat(" SELECT DISTINCT {0}, {1}, {2}", tblUnidades.Id, tblUnidades.Nome, tblUnidades.Status_Id);
            sql.AppendFormat(" FROM {0}", tblUnidades.NomeTabela);
            sql.AppendFormat(" WHERE {0}=@id", tblUnidades.Clientes_Id);
            sql.AppendFormat(" AND {0}=@status_id", tblUnidades.Status_Id);
            sql.AppendFormat(" ORDER BY {0};", tblUnidades.Nome);

            using (var dal = new DalHelperSqlServer())
            {
                try
                {
                    dal.CriarParametroDeEntrada("id", SqlDbType.Int, cliente.Id);
                    dal.CriarParametroDeEntrada("status_id", SqlDbType.SmallInt, status.GetHashCode());

                    using (var dr = dal.ExecuteReader(sql.ToString()))
                    {
                        while (dr.Read())
                        {
                            unidades.Add(new Unidade(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                (Status)dr.GetInt16(2)));
                        }
                    }
                }
                catch (SqlException) { throw new MyException("Operação não realizada, por favor, tente novamente!"); }
            }

            return unidades;
        }
        #endregion
    }
}