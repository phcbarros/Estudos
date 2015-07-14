using WebApplication.Dao.Interfaces.Crud;
using WebApplication.Models.Interfaces;
using WebApplication.Models.Interfaces.Persistencia;

namespace WebApplication.Dao.Interfaces
{
    public interface IDao<T> : IAlterar<T>, IConsultar<T>, IInativar<T>, IInserir<T> where T : class, IIdentity
    {
    }
}
