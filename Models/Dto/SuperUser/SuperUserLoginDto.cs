using FluentValidation;

namespace StarFitApi.Models.Dto.SuperUser;

public class SuperUserLoginDto : IDataTransferObject
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    
    private class Validator:AbstractValidator<SuperUserLoginDto>
    {
        public Validator()
        {
            RuleFor(s => s.Username).NotEmpty().MaximumLength(50);
            RuleFor(s => s.Password).NotEmpty().MaximumLength(50);
        }
    }
    
    public async Task Validate()
    {
        var validator = new Validator();
        await validator.ValidateAndThrowAsync(this);
    }
}