namespace WebApplication.Models.Interfaces.Crud
{
    public interface IAlterar<in T> where T : class
    {
        bool Alterar(T model);
    }
}
