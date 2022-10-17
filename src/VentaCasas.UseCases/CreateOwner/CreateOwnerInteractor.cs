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
    public class CreateOwnerInteractor : ICreateOwnerInputPort
    {
        private readonly IOwnerRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateOwnerOutputPort _outputPort;
        private readonly IMapper _imapper;
        public CreateOwnerInteractor(IOwnerRepository repository, IUnitOfWork unitOfWork, ICreateOwnerOutputPort outputPort, IMapper imapper) =>
            (_repository, _unitOfWork, _outputPort, _imapper) = (repository, unitOfWork, outputPort, imapper);
        public async Task Handle(CreateOwnerDTO owner)
        {
            var ownerValidator = await new CreateOwnerValidator().ValidateAsync(owner);
            if (!ownerValidator.IsValid) throw new ValidationException(ownerValidator.Errors);
            Owner NewOwner = _imapper.Map<Owner>(owner);
            await _repository.CreateOwner(NewOwner);
            try
            {
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al crear el Owner", ex.Message);
            }
            await _outputPort.Handle(_imapper.Map<OwnerDTO>(NewOwner));
        }
    }
}
