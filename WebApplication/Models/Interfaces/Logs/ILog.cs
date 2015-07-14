using System;
using WebApplication.Models.Interfaces.Crud;
using WebApplication.Models.Interfaces.Persistencia;

namespace WebApplication.Models.Interfaces.Logs
{
    public interface ILog : IIdentity, IInserir
    {
        #region Propriedades
        IUsuario Usuario { get; }
        string Operacao { get; }
        string Ip { get; }
        string Navegador { get; }
        DateTime DataHora { get; }
        #endregion
    }
}
