

using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.DayOfWalkServices;

public class DayOfWalkService : BaseService<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>, IDayOfWalkService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public DayOfWalkService(DataContext context) : base(context)
    {
        _context = context;
    }
    
    #endregion

    #region Methods

    

    #endregion
}

