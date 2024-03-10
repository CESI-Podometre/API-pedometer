using FluentValidation;

namespace StarFitApi.Models.Dto.DayOfWalk;

public class DayOfWalkCreateDto : IDataTransferObject
{
    public DateTime Date { get; set; }
    public int Steps { get; set; }
    public Guid UserId { get; set; }
    
    private class Validator:AbstractValidator<DayOfWalkCreateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Steps).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}