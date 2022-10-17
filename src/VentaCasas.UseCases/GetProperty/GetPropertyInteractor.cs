using AutoMapper;
using VentaCasas.DTOs;
using VentaCasas.Entities.Interfaces;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.UseCases
{
    public class GetPropertyInteractor : IGetPropertyInputPort
    {
        private readonly IPropertyRepository _repository;
        private readonly IGetPropertyOutputPort _outputPort;
        private readonly IMapper _imapper;
        public GetPropertyInteractor(IPropertyRepository repository, IGetPropertyOutputPort outputPort, IMapper imapper) =>
            (_repository, _outputPort, _imapper) = (repository, outputPort, imapper);
        public async Task<Task> Handle(int id)
        {
            var propertiesDto = _imapper.Map<PropertyDTO>(await _repository.GetPropertyAsync(id));
            await _outputPort.Handle(propertiesDto);
            return Task.CompletedTask;
        }
    }
}
