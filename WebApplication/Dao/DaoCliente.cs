using System;
using System.Collections.Generic;
using WebApplication.Dao.Interfaces;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao
{
    public class DaoCliente : IDaoCliente
    {
        public IList<ICliente> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Alterar(ICliente model)
        {
            throw new NotImplementedException();
        }

        public ICliente Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(ICliente model)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(ICliente model)
        {
            throw new NotImplementedException();
        }
    }
}