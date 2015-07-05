using System.Collections.Generic;
using WebApplication.Models;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDaoUnidade : IDao<IUnidade>
    {
        IList<IUnidade> Listar(ICliente model);
    }
}
