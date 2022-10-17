using AutoMapper;
using FluentValidation;
using VentaCasas.DTOs;
using VentaCasas.Entities.Interfaces;
using VentaCasas.Entities.POCOs;
using VentaCasas.UseCasesPorts;
using System.Threading.Tasks;

namespace VentaCasas.UseCases
{
    public class CreatePropertyImageInteractor : ICreatePropertyImageInputPort
    {
        private readonly IPropertyImageRepository _repository;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreatePropertyImageOutputPort _outputPort;
        private readonly IMapper _imapper;
        public CreatePropertyImageInteractor(IPropertyImageRepository repository, IPropertyRepository propertyRepository, IUnitOfWork unitOfWork, ICreatePropertyImageOutputPort outputPort, IMapper imapper) =>
            (_repository, _propertyRepository, _unitOfWork, _outputPort, _imapper) = (repository, propertyRepository, unitOfWork, outputPort, imapper);
        public async Task Handle(CreatePropertyImageDTO propertyImage)
        {
            var propertyImageValidator = new CreatePropertyImageValidator(_propertyRepository).Validate(propertyImage);
            if (!propertyImageValidator.IsValid) throw new ValidationException(propertyImageValidator.Errors);
            PropertyImage NewPropertyImage = _imapper.Map<PropertyImage>(propertyImage);
            _repository.AddImageProperty(NewPropertyImage);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(_imapper.Map<PropertyImageDTO>(NewPropertyImage));
        }
    }
}
