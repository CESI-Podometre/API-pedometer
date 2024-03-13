using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.DayOfWalkServices;

public interface IDayOfWalkService : IBaseService<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>
{
    public Task<DayOfWalk> UserCreateOrUpdate(Guid id, DayOfWalkUserCreateOrUpdateDto dayOfWalkUserCreateOrUpdateDto);

}