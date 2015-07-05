using System;
using System.Collections.Generic;
using WebApplication.Dao.Interfaces;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao
{
    public class DaoUnidade : IDaoUnidade
    {
        public IList<IUnidade> Listar(ICliente model)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(IUnidade model)
        {
            throw new NotImplementedException();
        }

        public IUnidade Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(IUnidade model)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(IUnidade model)
        {
            throw new NotImplementedException();
        }
    }
}