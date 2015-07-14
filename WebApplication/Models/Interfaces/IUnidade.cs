using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface IUnidade : IModel<IUnidade>
    {
        #region Propriedades
        string Nome { get; }
        ICliente Cliente { get; }
        #endregion

        #region Listar
        IList<IUnidade> Listar(ICliente model);
        #endregion
    }
}
