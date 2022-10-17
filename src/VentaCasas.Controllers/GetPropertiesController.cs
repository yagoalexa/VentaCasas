using Microsoft.AspNetCore.Mvc;
using VentaCasas.DTOs;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VentaCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPropertiesController
    {
        private readonly IGetPropertiesInputPort _inputPort;
        private readonly IGetPropertiesOutputPort _outputPort;
        public GetPropertiesController(IGetPropertiesInputPort inputPort, IGetPropertiesOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet]
        public async Task<IEnumerable<PropertyDTO>> GetProperties()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PropertyDTO>>)_outputPort).Content;
        }
    }
}
