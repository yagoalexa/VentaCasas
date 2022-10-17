using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreateOwnerInputPort
    {
        Task Handle(CreateOwnerDTO owner);
    }
}
