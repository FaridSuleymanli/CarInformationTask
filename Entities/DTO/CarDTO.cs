using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Entities.DTO
{
    public class CarDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Price { get; set; }
        public int CarTypeId { get; set; }
    }

    public class CarDTOValidation : AbstractValidator<CarDTO>
    {
        public CarDTOValidation()
        {
            RuleFor(r => r.Brand)
                .NotEmpty().WithMessage("Brand cannot be empty")
                .MaximumLength(50);

            RuleFor(r => r.Model)
                .NotEmpty().WithMessage("Model cannot be empty")
                .MaximumLength(50);

            RuleFor(r => r.Price)
                .NotEmpty().WithMessage("Price cannot be empty");

            RuleFor(r => r.Year)
                .NotEmpty().WithMessage("Year cannot be empty");

            RuleFor(r => r.CarTypeId)
                .NotEmpty().WithMessage("Year cannot be empty");
        }
    }
}
