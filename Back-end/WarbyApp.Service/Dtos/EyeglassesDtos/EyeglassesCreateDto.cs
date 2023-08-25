﻿using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarbyApp.Core.Entities;

namespace WarbyApp.Service.Dtos.EyeglassesDtos
{
    public class EyeglassesCreateDto
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public List<IFormFile> ImageFiles { get; set; }
    }
    public class EyeglassesCreateDtoValidator : AbstractValidator<EyeglassesCreateDto>
    {
        public EyeglassesCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().MaximumLength(35);
            RuleFor(x => x.Material)
                .NotEmpty().MaximumLength(30);
            RuleFor(x => x.SalePrice)
                .GreaterThan(0);
            RuleFor(x => x.CostPrice)
                .LessThanOrEqualTo(x => x.SalePrice);
            RuleFor(x => x.DiscountPercent)
                .InclusiveBetween(0, 100);

            RuleFor(x => x.ImageFiles).NotNull();

            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.ImageFiles != null)
                {
                    foreach(var file in x.ImageFiles)
                    {
                        if (file.Length > 2 * 1024 * 1024)
                            context.AddFailure("ImageFile", "Image file must be less or equal that 2MB");

                        if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                            context.AddFailure("ImageFile", "Image file must be png,jpg or jpeg");
                    }
                }

            });
        }
    }
}