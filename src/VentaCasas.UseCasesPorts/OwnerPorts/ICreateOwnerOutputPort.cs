using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreateOwnerOutputPort
    {
        Task Handle(OwnerDTO owner);
    }
}
