using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.DayOfWalkServices;

public interface IDayOfWalkService : IBaseService<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>
{
    public Task<DayOfWalk> UserCreateOrUpdate(Guid id, DayOfWalkUserCreateOrUpdateDto dayOfWalkUserCreateOrUpdateDto);
    public Task<GlobalProgression> GetGlobalProgression();
}