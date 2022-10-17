﻿using AutoMapper;
using FluentValidation;
using VentaCasas.DTOs;
using VentaCasas.Entities.Exceptions;
using VentaCasas.Entities.Interfaces;
using VentaCasas.Entities.POCOs;
using VentaCasas.UseCasesPorts;
using System;
using System.Threading.Tasks;

namespace VentaCasas.UseCases
{
    public class UpdatePropertyInteractor : IUpdatePropertyInputPort
    {
        private readonly IPropertyRepository _repository;
        private readonly IOwnerRepository _ownerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdatePropertyOutputPort _outputPort;
        private readonly IMapper _imapper;
        public UpdatePropertyInteractor(IPropertyRepository repository, IOwnerRepository ownerRepository, IUnitOfWork unitOfWork, IUpdatePropertyOutputPort outputPort, IMapper imapper) =>
        (_repository, _ownerRepository, _unitOfWork, _outputPort, _imapper) = (repository, ownerRepository, unitOfWork, outputPort, imapper);
        public async Task Handle(UpdatePropertyDTO property)
        {
            var propertyValidator = new UpdatePropertyValidator(_repository, _ownerRepository).Validate(property);
            if (!propertyValidator.IsValid) throw new ValidationException(propertyValidator.Errors);
            Property NewProperty = _imapper.Map<Property>(property);
            await _repository.UpdatePropertyAsync(NewProperty);
            try
            {
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al actualizar la propiedad", ex.Message);
            }
            await _outputPort.Handle(_imapper.Map<PropertyDTO>(NewProperty));
        }
    }
}
