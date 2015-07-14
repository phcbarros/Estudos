using System;
using WebApplication.Models.Enums;

namespace WebApplication.Models.Interfaces.Logs
{
    public interface ILog
    {
        #region Propriedades
        IUsuario Usuario { get; }
        Operacao Operacao { get; }
        DateTime DataHora { get; }
        #endregion
    }
}
