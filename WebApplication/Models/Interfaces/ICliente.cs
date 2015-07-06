using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface ICliente : IClasseBase
    {
        string Nome { get; }
        IList<IUnidade> Unidades { get; }
        IList<ICliente> Listar();
        void PreencherUnidades();
        bool Alterar();
        ICliente Consultar(int id);
        bool Inativar();
        void Inserir();
    }
}
