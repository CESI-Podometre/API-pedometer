using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.ChallengeServices;

public interface IChallengeService : IBaseService<Challenge, ChallengeCreateDto, ChallengeUpdateDto>
{
    public Task<IEnumerable<Challenge>> GetUserContent(Guid id);
}