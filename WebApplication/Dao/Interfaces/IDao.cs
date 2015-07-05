using WebApplication.Models.Interfaces.Crud;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDao<T> : IAlterar<T>, IConsultar<T>, IInativar<T>, IInserir<T> where T : class, IClasseBase
    {
    }
}
