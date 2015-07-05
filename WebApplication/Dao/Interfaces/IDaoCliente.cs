using System.Collections.Generic;
using WebApplication.Models;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDaoCliente : IDao<ICliente>
    {
        IList<ICliente> Listar();
    }
}
