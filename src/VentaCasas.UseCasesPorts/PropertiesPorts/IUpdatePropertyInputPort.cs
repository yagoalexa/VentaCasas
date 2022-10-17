using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IUpdatePropertyInputPort
    {
        Task Handle(UpdatePropertyDTO property);
    }
}
