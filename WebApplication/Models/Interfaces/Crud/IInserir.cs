namespace WebApplication.Models.Interfaces.Crud
{
    public interface IInserir<in T> where T : class
    {
        int Inserir(T model);
    }
}
