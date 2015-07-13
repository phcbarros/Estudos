using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface ICliente : IModel<ICliente>
    {
        string Nome { get; }
        IList<IUnidade> Unidades { get; }
        IList<ICliente> Listar();
        void PreencherUnidades();
    }
}
