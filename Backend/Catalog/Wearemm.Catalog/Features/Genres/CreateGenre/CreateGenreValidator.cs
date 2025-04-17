using FluentValidation;

namespace Wearemm.Catalog.Features.Genres.CreateGenre;

public class CreateGenreValidator : AbstractValidator<CreateGenreRequest>
{
    public CreateGenreValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("Name is required.");
    }
}
