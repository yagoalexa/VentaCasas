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
    public class GetPropertyImagesController
    {
        private readonly IGetPropertyImagesInputPort _inputPort;
        private readonly IGetPropertyImagesOutputPort _outputPort;
        public GetPropertyImagesController(IGetPropertyImagesInputPort inputPort, IGetPropertyImagesOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet("{id}")]
        public async Task<IEnumerable<PropertyImageDTO>> GetProperties(int id)
        {
            await _inputPort.Handle(propertyId : id);
            return ((IPresenter<IEnumerable<PropertyImageDTO>>)_outputPort).Content;
        }
    }
}
