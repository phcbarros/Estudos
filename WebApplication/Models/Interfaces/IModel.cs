using System;
using WebApplication.Models.Enums;

namespace WebApplication.Models.Interfaces
{
    public interface IModel : IIdentity
    {
        Status Status { get; }
    }
}
