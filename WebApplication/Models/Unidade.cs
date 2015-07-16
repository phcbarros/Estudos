using System;
using System.Collections.Generic;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Dao.Interfaces.Logs;
using WebApplication.Dao.Logs;
using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Unidade : ClasseBase, IUnidade
    {
        #region Propriedades
        public string Nome { get; private set; }
        public ICliente Cliente { get; private set; }

        private static readonly IDaoUnidade _daoUnidade;
        private static readonly IDaoUnidadeLog _daoUnidadeLog;
        #endregion

        #region Construtores
        static Unidade()
        {
            _daoUnidade = new DaoUnidade();
            _daoUnidadeLog = new DaoUnidadeLog();
        }
        public Unidade()
        {

        }
        public Unidade(int id, string nome, Status status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Status = status;
        }
        #endregion

        #region Alterar
        /// <exception cref="MyException"></exception>
        public bool Alterar()
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
        public bool Inativar()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inserir
        /// <exception cref="MyException"></exception>
        public void Inserir()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Listar
        /// <exception cref="MyException"></exception>
        public IList<IUnidade> Listar(ICliente cliente)
        {
            cliente.ValidarId();

            return _daoUnidade.Listar(cliente, Status.Ativo);
        }
        #endregion

    }
}