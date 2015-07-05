using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces.Crud;

namespace WebApplication.Models.Interfaces
{
    public interface IClasseBase //: IAlterar<T>, IConsultar<T>, IInativar<T>, IInserir<T>
    {
        int Id { get; }
        Status Status { get; }
    }
}
