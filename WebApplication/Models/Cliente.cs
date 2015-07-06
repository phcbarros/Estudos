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
    public class Cliente : ClasseBase, ICliente
    {
        public string Nome { get; private set; }
        public IList<IUnidade> Unidades { get; private set; }
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
            IDaoCliente daoCliente = new DaoCliente();
            return daoCliente.Listar();
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
            if (string.IsNullOrEmpty(Nome))
                throw new MyException("Nome é obrigatório!");

            //Criar Validação de Já Existente
            //Dividir em métodos

            this.Status = Status.Ativo;

            IDaoCliente daoCliente = new DaoCliente();
            this.Id = daoCliente.Inserir(this);

            //Criar Log por tabela
        }
    }
}