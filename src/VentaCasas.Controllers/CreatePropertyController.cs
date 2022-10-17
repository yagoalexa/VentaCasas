using Microsoft.AspNetCore.Mvc;
using VentaCasas.DTOs;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePropertyController
    {
        private readonly ICreatePropertyInputPort _inputPort;
        private readonly ICreatePropertyOutputPort _outputPort;
        public CreatePropertyController(ICreatePropertyInputPort inputPort, ICreatePropertyOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<PropertyDTO> CreateProperty(CreatePropertyDTO property) {
            await _inputPort.Handle(property);
            return ((IPresenter<PropertyDTO>)_outputPort).Content;
        }
    }
}
