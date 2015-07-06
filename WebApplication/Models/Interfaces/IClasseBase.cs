using WebApplication.Models.Enums;

namespace WebApplication.Models.Interfaces
{
    public interface IClasseBase
    {
        int Id { get; }
        Status Status { get; }
    }
}
