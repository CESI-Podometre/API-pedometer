using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.BadgeServices;

public class BadgeService : BaseService<Badge, BadgeCreateDto, BadgeUpdateDto>, IBadgeService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public BadgeService(DataContext context) : base(context)
    {
        _context = context;
    }
    
    #endregion

    #region Methods

    

    #endregion
}