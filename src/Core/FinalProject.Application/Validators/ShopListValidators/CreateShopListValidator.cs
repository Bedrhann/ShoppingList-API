﻿using FinalProject.Application.Features.ShopListFeatures.Commands.CreateShopList;
using FluentValidation;

namespace FinalProject.Application.Validators.ShopListValidators
{
    public class CreateShopListValidator : AbstractValidator<CreateShopListCommandRequest>
    {
        public CreateShopListValidator()
        {
            RuleFor(c => c.AppUserId)
            .NotNull().NotEmpty()
            .WithMessage("Please specify a valid Id for Category!");

            RuleFor(c => c.Name)
            .NotNull().NotEmpty()
            .WithMessage("Please specify a Name!");

            RuleFor(c => c.Description)
            .NotNull().NotEmpty()
            .WithMessage("Please specify a Quantity!")
            .WithMessage("Quantity cannot be less than zero");
        }
    }
}
