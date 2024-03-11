using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.BadgeServices;

public interface IBadgeService : IBaseService<Badge, BadgeCreateDto, BadgeUpdateDto> { }