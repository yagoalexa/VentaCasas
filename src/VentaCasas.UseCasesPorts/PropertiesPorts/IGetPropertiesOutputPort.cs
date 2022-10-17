using VentaCasas.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IGetPropertiesOutputPort
    {
        Task Handle(IEnumerable<PropertyDTO> properties);
    }
}
