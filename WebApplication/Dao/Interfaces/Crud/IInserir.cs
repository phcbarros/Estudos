namespace WebApplication.Dao.Interfaces.Crud
{
    public interface IInserir<in T> where T : class
    {
        int Inserir(T model);
    }
}
