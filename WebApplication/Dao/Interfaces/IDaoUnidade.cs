using System.Collections.Generic;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDaoUnidade : IDao<IUnidade>
    {
        #region Listar
        IList<IUnidade> Listar(ICliente model, Status status);
        #endregion
    }
}
