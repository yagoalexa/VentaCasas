using VentaCasas.DTOs;
using VentaCasas.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaCasas.Presenters
{
    public class GetPropertyPresenter : IGetPropertyOutputPort , IPresenter<PropertyDTO>
    {
        public PropertyDTO Content { get; private set; }

        public Task Handle(PropertyDTO property)
        {
            Content = property;
            return Task.CompletedTask;
        }
    }
}
