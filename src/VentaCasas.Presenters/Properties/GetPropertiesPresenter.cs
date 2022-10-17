using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaCasas.DTOs;
using VentaCasas.UseCasesPorts;

namespace VentaCasas.Presenters
{
    public class GetPropertiesPresenter : IGetPropertiesOutputPort, IPresenter<IEnumerable<PropertyDTO>>
    {
        public IEnumerable<PropertyDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyDTO> properties)
        {
            Content = properties;
            return Task.CompletedTask;
        }
    }
}
