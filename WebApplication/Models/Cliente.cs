﻿using System;
using System.Collections.Generic;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Cliente : ClasseBase, ICliente
    {
        public string Nome { get; private set; }
        public IList<IUnidade> Unidades { get; private set; }

        private static readonly IDaoCliente _daoCliente;
        static Cliente()
        {
            _daoCliente = new DaoCliente();
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
        public IList<ICliente> Listar()
        {
            return _daoCliente.Listar();
        }
        public void PreencherUnidades()
        {
            IUnidade unidade = new Unidade();
            this.Unidades = unidade.Listar(this);
        }

        public bool Alterar()
        {
            throw new NotImplementedException();
        }

        public ICliente Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Inativar()
        {
            throw new NotImplementedException();
        }

        /// <exception cref="MyException"></exception>
        public void Inserir()
        {
            ValidarNome();

            //if (daoCliente.ExisteNomenclaturaInformada(this))
            //    throw new MyException("Já existe o Nome informado!");

            this.Status = Status.Ativo;
            this.Id = _daoCliente.Inserir(this);

            //Criar Log por tabela
        }

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