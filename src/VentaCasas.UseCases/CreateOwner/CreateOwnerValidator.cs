﻿using FluentValidation;
using VentaCasas.DTOs;

namespace VentaCasas.UseCases
{
    public class CreateOwnerValidator : AbstractValidator<CreateOwnerDTO>
    {
        public CreateOwnerValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Se requiere el nombre")
                .NotEmpty().WithMessage("El nombre no puede estar vacío");
            RuleFor(x => x.Address)
                .NotNull().WithMessage("Se requiere la dirección")
                .NotEmpty().WithMessage("La dirección no puede estar vacía");
        }
    }
}
