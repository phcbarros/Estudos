using System.Collections.Generic;

namespace WebApplication.Models.Interfaces
{
    public interface IUnidade : IModel<IUnidade>
    {
        string Nome { get; }
        ICliente Cliente { get; }
        IList<IUnidade> Listar(ICliente model);
    }
}
