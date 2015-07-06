using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface IUnidade : IClasseBase
    {
        string Nome { get; }
        ICliente Cliente { get; }
        IList<IUnidade> Listar(ICliente model);
        bool Alterar();
        IUnidade Consultar(int id);
        bool Inativar();
        void Inserir();
    }
}
