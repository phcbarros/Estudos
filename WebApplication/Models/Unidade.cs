using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public Unidade()
        {

        }
        public Unidade(int id, string nome, Status status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Status = status;
        }
        public IList<IUnidade> Listar(ICliente model)
        {
            if (model == null || model.Id <= 0)
                throw new MyException("Id é obrigatório!");

            IDaoUnidade daoUnidade = new DaoUnidade();
            return daoUnidade.Listar(model);
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