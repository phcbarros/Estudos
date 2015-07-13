namespace WebApplication.Models.Interfaces.Crud
{
    public interface IConsultar<out T> where T : class
    {
        T Consultar(int id);
    }
}
