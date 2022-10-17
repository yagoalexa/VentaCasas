﻿using AutoMapper;
using FluentValidation;
using VentaCasas.DTOs;
using VentaCasas.Entities.Exceptions;
using VentaCasas.Entities.Interfaces;
using VentaCasas.Entities.POCOs;
using VentaCasas.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaCasas.UseCases
{
    public class CreatePropertyInteractor : ICreatePropertyInputPort
    {
        private readonly IPropertyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreatePropertyOutputPort _outputPort;
        private readonly IMapper _imapper;
        public CreatePropertyInteractor(IPropertyRepository repository, IUnitOfWork unitOfWork, ICreatePropertyOutputPort outputPort, IMapper imapper) =>
            (_repository, _unitOfWork, _outputPort, _imapper) = (repository, unitOfWork, outputPort, imapper);
        public async Task Handle(CreatePropertyDTO property)
        {
            var propertyValidator = new CreatePropertyValidator().Validate(property);
            if (!propertyValidator.IsValid) throw new ValidationException(propertyValidator.Errors);
            Property NewProperty = _imapper.Map<Property>(property);
            await _repository.CreatePropertyAsync(NewProperty);
            try
            {
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al crear la propiedad", ex.Message);
            }
            await _outputPort.Handle(_imapper.Map<PropertyDTO>(NewProperty));
        }
    }
}
