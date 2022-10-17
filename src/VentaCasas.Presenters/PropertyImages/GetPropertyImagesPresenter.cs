using VentaCasas.DTOs;
using VentaCasas.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VentaCasas.Presenters
{
    public class GetPropertyImagesPresenter : IGetPropertyImagesOutputPort, IPresenter<IEnumerable<PropertyImageDTO>>
    {
        public IEnumerable<PropertyImageDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyImageDTO> propertyImages)
        {
            Content = propertyImages;
            return Task.CompletedTask;
        }
    }
}
