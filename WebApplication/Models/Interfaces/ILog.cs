using System;

namespace WebApplication.Models.Interfaces
{
    public interface ILog : IIdentity
    {
        IUsuario Usuario { get; }
        string Operacao { get; }
        string Ip { get; }
        string Navegador { get; }
        DateTime DataHora { get; }
        void Inserir();
    }
}
