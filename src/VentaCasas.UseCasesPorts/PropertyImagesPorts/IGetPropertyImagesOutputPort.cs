using VentaCasas.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IGetPropertyImagesOutputPort
    {
        Task Handle(IEnumerable<PropertyImageDTO> propertyImages);
    }
}
