namespace WebApplication.Dao.Interfaces.Crud
{
    public interface IInativar<in T> where T : class
    {
        bool Inativar(T model);
    }
}
