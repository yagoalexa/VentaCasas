using VentaCasas.DTOs;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.Presenters
{
    public class UpdatePropertyPresenter : IUpdatePropertyOutputPort, IPresenter<PropertyDTO>
    {
        public PropertyDTO Content { get; private set; }

        public Task Handle(PropertyDTO property)
        {
            Content = property;
            return Task.CompletedTask;
        }
    }
}
