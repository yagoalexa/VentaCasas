using AutoMapper;
using VentaCasas.DTOs;
using VentaCasas.Entities.Interfaces;
using VentaCasas.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VentaCasas.UseCases
{
    public class GetPropertiesInteractor : IGetPropertiesInputPort
    {
        private readonly IPropertyRepository _repository;
        private readonly IGetPropertiesOutputPort _outputPort;
        private readonly IMapper _imapper;
        public GetPropertiesInteractor(IPropertyRepository repository, IGetPropertiesOutputPort outputPort, IMapper imapper) =>
            (_repository, _outputPort, _imapper) = (repository, outputPort, imapper);
        public async Task<Task> Handle()
        {
            var propertiesDto = _imapper.Map<IEnumerable<PropertyDTO>>(await _repository.GetPropertiesAsync());
            await _outputPort.Handle(propertiesDto);
            return Task.CompletedTask;
        }
    }
}
