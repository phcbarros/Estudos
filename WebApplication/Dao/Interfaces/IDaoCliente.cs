using System.Collections.Generic;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDaoCliente : IDao<ICliente>
    {
        #region Listar
        IList<ICliente> Listar(Status status);
        #endregion

        #region Validações
        bool ExisteNomenclaturaInformada(ICliente cliente);
        #endregion
    }
}
