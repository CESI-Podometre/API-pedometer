using FluentValidation;

namespace StarFitApi.Models.Dto.Article;

public class ArticleUpdateDto : IDataTransferObject
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public IFormFile? Image { get; set; } = null!;
    public IFormFile? File { get; set; } = null!;
    internal string? ImagePath { get; set; }
    internal string? FilePath { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    
    private class Validator:AbstractValidator<ArticleUpdateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
            RuleFor(x => x.StartDate).NotEmpty();
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}