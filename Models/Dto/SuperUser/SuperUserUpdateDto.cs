using FluentValidation;

namespace StarFitApi.Models.Dto.SuperUser;

public class SuperUserUpdateDto : IDataTransferObject
{
    public string Username { get; set; } = null!;
    
    private class Validator:AbstractValidator<SuperUserUpdateDto>
    {
        public Validator()
        {
            RuleFor(s => s.Username).NotEmpty().MaximumLength(50);
        }
    }
}