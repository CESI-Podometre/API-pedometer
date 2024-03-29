using FluentValidation;

namespace StarFitApi.Models.Dto.Badge;

public class BadgeUpdateDto : IDataTransferObject
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public IFormFile? Image { get; set; } = null!;
    internal string? ImagePath { get; set; } = null!;
    
    private class Validator:AbstractValidator<BadgeUpdateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}