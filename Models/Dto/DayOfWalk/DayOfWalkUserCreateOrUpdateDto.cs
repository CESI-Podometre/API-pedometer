using FluentValidation;

namespace StarFitApi.Models.Dto.DayOfWalk;

public class DayOfWalkUserCreateOrUpdateDto : IDataTransferObject
{
    public DateTime Date { get; set; }
    public int Steps { get; set; }
    
    private class Validator:AbstractValidator<DayOfWalkUserCreateOrUpdateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Steps).NotEmpty();
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}