using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Cliente : ClasseBase, ICliente
    {
        public string Nome { get; private set; }
        public IList<IUnidade> Unidades { get; private set; }

        private static IDaoCliente DaoCliente = new DaoCliente();
        public Cliente()
        {

        }
        public Cliente(int id, string nome, Status status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Status = status;
        }
        public IList<ICliente> Listar()
        {
            return DaoCliente.Listar();
        }
        public void PreencherUnidades()
        {
            throw new NotImplementedException();
        }
    }
}