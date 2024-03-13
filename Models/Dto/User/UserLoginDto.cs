using FluentValidation;

namespace StarFitApi.Models.Dto.User;

public class UserLoginDto : IDataTransferObject
{
    public string Identifier { get; set; } = null!;

    private class Validator:AbstractValidator<UserLoginDto>
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