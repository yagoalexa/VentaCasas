using Microsoft.AspNetCore.Mvc;
using VentaCasas.DTOs;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPropertyController
    {
        private readonly IGetPropertyInputPort _inputPort;
        private readonly IGetPropertyOutputPort _outputPort;
        public GetPropertyController(IGetPropertyInputPort inputPort, IGetPropertyOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet("{id}")]
        public async Task<PropertyDTO> GetProperty(int id)
        {
            await _inputPort.Handle(id);
            return ((IPresenter<PropertyDTO>)_outputPort).Content;
        }
    }
}
