using WebApplication.Models.Interfaces;

namespace WebApplication.Dao.Interfaces.Crud
{
    public partial interface IInserir<in T1, in T2>
        where T1 : class, IIdentity
        where T2 : class
    {
        void Inserir(T1 model1, T2 model2);
    }
}
