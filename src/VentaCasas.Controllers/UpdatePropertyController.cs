using Microsoft.AspNetCore.Mvc;
using VentaCasas.DTOs;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePropertyController
    {
        private readonly IUpdatePropertyInputPort _inputPort;
        private readonly IUpdatePropertyOutputPort _outputPort;
        public UpdatePropertyController(IUpdatePropertyInputPort inputPort, IUpdatePropertyOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<PropertyDTO> CreateProperty(UpdatePropertyDTO property)
        {
            await _inputPort.Handle(property);
            return ((IPresenter<PropertyDTO>)_outputPort).Content;
        }
    }
}
