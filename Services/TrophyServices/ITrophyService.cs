using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Trophy;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.TrophyServices;

public interface ITrophyService : IBaseService<Trophy, TrophyCreateDto, TrophyUpdateDto> { }