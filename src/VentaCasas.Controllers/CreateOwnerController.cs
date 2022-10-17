using Microsoft.AspNetCore.Mvc;
using VentaCasas.DTOs;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOwnerController
    {
        private readonly ICreateOwnerInputPort _inputPort;
        private readonly ICreateOwnerOutputPort _outputPort;
        public CreateOwnerController(ICreateOwnerInputPort inputPort, ICreateOwnerOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<OwnerDTO> CreateOwner(CreateOwnerDTO owner)
        {
            await _inputPort.Handle(owner);
            return ((IPresenter<OwnerDTO>)_outputPort).Content;
        }
    }
}
