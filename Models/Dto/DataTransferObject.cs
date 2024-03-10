using FluentValidation;

namespace StarFitApi.Models.Dto;

public interface IDataTransferObject
{
    private class Validator : AbstractValidator<IDataTransferObject>
    {
        public Validator()
        {
            RuleFor(x => x).NotNull();
        }
    }

    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    } 
}