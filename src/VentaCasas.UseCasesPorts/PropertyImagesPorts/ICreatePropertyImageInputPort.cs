using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreatePropertyImageInputPort
    {
        Task Handle(CreatePropertyImageDTO propertyImage);
    }
}
