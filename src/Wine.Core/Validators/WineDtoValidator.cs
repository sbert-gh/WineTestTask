using FluentValidation;
using WineCatalog.Core.Models;

namespace WineCatalog.Core.Validators
{
    public class WineDtoValidator : AbstractValidator<WineDto>
    {
        public WineDtoValidator()
        {
            RuleFor(w => w.Title).NotEmpty();
            RuleFor(w => w.Year).LessThanOrEqualTo(DateTime.Now.Year);
            RuleFor(w => w.Brand).NotEmpty();
            RuleFor(w => w.Type).NotEmpty();
        }
    }
}
