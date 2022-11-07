using ETicaretAPI.Application.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>{
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(100).MinimumLength(5).WithMessage("Ürün adı boş geçilemez");
            RuleFor(p => p.Stock).NotEmpty().NotNull().Must(s => s >= 0).WithMessage("Stok adedi negatif olamaz");
            RuleFor(p => p.Price).NotEmpty().NotNull().Must(s => s >= 0).WithMessage("Fiyat bilgisi negatif olamaz");
        }
    }
}
    

