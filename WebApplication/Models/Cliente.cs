using System;
using System.Collections.Generic;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Dao.Interfaces.Logs;
using WebApplication.Dao.Logs;
using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;
using WebApplication.Models.Interfaces;
using WebApplication.Models.Interfaces.Logs;
using WebApplication.Models.Logs;

namespace WebApplication.Models
{
    public class Cliente : ClasseBase, ICliente
    {
        #region Propriedades
        public string Nome { get; private set; }
        public IList<IUnidade> Unidades { get; private set; }

        private static readonly IDaoCliente _daoCliente;
        private static readonly IDaoClienteLog _daoClienteLog;
        #endregion

        #region Construtores
        static Cliente()
        {
            _daoCliente = new DaoCliente();
            _daoClienteLog = new DaoClienteLog();
        }
        public Cliente(int id)
        {
            this.Id = id;
        }
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        public Cliente(int id, string nome, Status status)
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
            base.ValidarId();
            this.ValidarNome();
            throw new NotImplementedException();
        }
        #endregion

        #region Consultar
        /// <exception cref="MyException"></exception>
        public ICliente Consultar(int id)
        {
            base.ValidarId();
            throw new NotImplementedException();
        }
        #endregion

        #region Inativar
        /// <exception cref="MyException"></exception>
        public bool Inativar()
        {
            base.ValidarId();
            throw new NotImplementedException();
        }
        #endregion

        #region Inserir
        /// <exception cref="MyException"></exception>
        public void Inserir()
        {
            this.ValidarNome();

            if (_daoCliente.ExisteNomenclaturaInformada(this))
                throw new MyException("Já existe o Nome informado!");

            this.Status = Status.Ativo;
            this.Id = _daoCliente.Inserir(this);

            ILog log = new Log(Operacao.Inserir);
            _daoClienteLog.Inserir(this, log);
        }
        #endregion

        #region Listar
        /// <exception cref="MyException"></exception>
        public IList<ICliente> Listar()
        {
            return _daoCliente.Listar(Status.Ativo);
        }
        #endregion

        #region Preencher
        /// <exception cref="MyException"></exception>
        public void PreencherUnidades()
        {
            IUnidade unidade = new Unidade();
            this.Unidades = unidade.Listar(this);
        }
        #endregion

        #region Validações
        /// <exception cref="MyException"></exception>
        private void ValidarNome()
        {
            if (string.IsNullOrEmpty(this.Nome))
                throw new MyException("Nome é obrigatório!");
        }
        #endregion

    }
}