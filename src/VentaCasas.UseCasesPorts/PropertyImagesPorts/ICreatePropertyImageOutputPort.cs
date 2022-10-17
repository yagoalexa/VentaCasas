using VentaCasas.DTOs;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface ICreatePropertyImageOutputPort
    {
        Task Handle(PropertyImageDTO propertyImage);
    }
}
