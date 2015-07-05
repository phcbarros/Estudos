namespace WebApplication.Models.Interfaces
{
    public interface IUnidade : IClasseBase
    {
        string Nome { get; }
        ICliente Cliente { get; }
    }
}
