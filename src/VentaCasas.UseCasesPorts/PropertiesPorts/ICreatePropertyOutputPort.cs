using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
