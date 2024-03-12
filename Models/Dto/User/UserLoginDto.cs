using FluentValidation;

namespace StarFitApi.Models.Dto.User;

public class UserLoginDto : IDataTransferObject
{
    public string Identifier { get; set; } = null!;

    private class Validator:AbstractValidator<UserCreateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Identifier).NotEmpty().MaximumLength(50);
        }
    }
}