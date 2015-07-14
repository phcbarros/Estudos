using System;
using System.Collections.Generic;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Unidade : ClasseBase, IUnidade
    {
        public string Nome { get; private set; }
        public ICliente Cliente { get; private set; }

        private static readonly IDaoUnidade _daoUnidade;
        static Unidade()
        {
            _daoUnidade = new DaoUnidade();
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
        /// <exception cref="MyException"></exception>
        public IList<IUnidade> Listar(ICliente model)
        {
            model.ValidarModelo();

            return _daoUnidade.Listar(model);
        }

        public bool Alterar()
        {
            throw new NotImplementedException();
        }

        public IUnidade Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Inativar()
        {
            throw new NotImplementedException();
        }

        public void Inserir()
        {
            throw new NotImplementedException();
        }
    }
}