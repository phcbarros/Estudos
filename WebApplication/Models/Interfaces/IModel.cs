using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces.Crud;
using WebApplication.Models.Interfaces.Persistencia;

namespace WebApplication.Models.Interfaces
{
    public interface IModel<T> : IIdentity, IAlterar, IConsultar<T>, IInativar, IInserir where T : class
    {
        #region Propriedades
        Status Status { get; }
        #endregion
    }
}
