using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface ICliente : IModel<ICliente>
    {
        #region Propriedades
        string Nome { get; }
        IList<IUnidade> Unidades { get; }
        #endregion

        #region Listar
        IList<ICliente> Listar();
        #endregion

        #region Preencher
        void PreencherUnidades();
        #endregion
    }
}
