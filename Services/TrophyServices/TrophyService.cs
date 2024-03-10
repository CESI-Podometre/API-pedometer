using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Trophy;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.TrophyServices;

public class TrophyService : BaseService<Trophy, TrophyCreateDto, TrophyUpdateDto>, ITrophyService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public TrophyService(DataContext context) : base(context)
    {
        _context = context;
    }
    
    #endregion

    #region Methods

    

    #endregion
}