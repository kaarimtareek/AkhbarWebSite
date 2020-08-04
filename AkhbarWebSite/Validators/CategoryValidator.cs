using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkhbarWebSite.DTOs.Category;
using FluentValidation;

namespace AkhbarWebSite.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator()
        {
            RuleFor<string>(c => c.Name).Cascade(CascadeMode.StopOnFirstFailure).NotNull().NotEmpty();
            RuleFor<string>(c => c.Description).Cascade(CascadeMode.StopOnFirstFailure).NotNull().NotEmpty();
            RuleFor<Guid>(c => c.Id).NotNull().NotEmpty();
        }
    }
}
