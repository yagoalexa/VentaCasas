using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IGetPropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
