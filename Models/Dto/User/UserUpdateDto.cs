using FluentValidation;

namespace StarFitApi.Models.Dto.User;

public class UserUpdateDto : IDataTransferObject
{
    public string Identifier { get; set; } = null!;
    
    private class Validator:AbstractValidator<UserUpdateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Identifier).NotEmpty().MaximumLength(50);
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}