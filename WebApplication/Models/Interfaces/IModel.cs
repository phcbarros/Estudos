using System;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces.Crud;

namespace WebApplication.Models.Interfaces
{
    public interface IModel<T> : IIdentity, IAlterar, IConsultar<T>, IInativar, IInserir where T : class
    {
        Status Status { get; }
    }
}
