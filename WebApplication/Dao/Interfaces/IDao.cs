using WebApplication.Dao.Interfaces.Crud;
using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces
{
    public interface IDao<T> : IAlterar<T>, IConsultar<T>, IInserir<T>, IInativar<T> where T : class, IClasseBase
    {
    }
}
