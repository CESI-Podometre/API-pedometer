using FluentValidation;

namespace StarFitApi.Models.Dto.Challenge;

public class ChallengeCreateDto : IDataTransferObject
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsGlobal { get; set; }
    public int Objective { get; set; }
    public Guid TrophyId { get; set; }

    private class Validator:AbstractValidator<ChallengeCreateDto>
    {
        public Validator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
            RuleFor(x => x.StartDate).NotEmpty();
            RuleFor(x => x.Objective).NotEmpty();
            RuleFor(x => x.TrophyId).NotEmpty();
        }
    }
}