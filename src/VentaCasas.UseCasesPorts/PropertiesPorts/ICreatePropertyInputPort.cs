using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreatePropertyInputPort
    {
        Task Handle(CreatePropertyDTO property);
    }
}
