using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IUpdatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
