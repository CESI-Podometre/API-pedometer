using FluentValidation;

namespace StarFitApi.Models.Dto.Badge;

public class BadgeCreateDto : IDataTransferObject
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public IFormFile Image { get; set; } = null!;
    
    private class Validator:AbstractValidator<BadgeCreateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
            RuleFor(x => x.Image).NotEmpty();
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}