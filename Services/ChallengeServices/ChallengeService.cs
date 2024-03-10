using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.ChallengeServices;

public class ChallengeService : BaseService<Challenge, ChallengeCreateDto, ChallengeUpdateDto>, IChallengeService
{
    #region Fields

    private readonly DataContext _context;

    #endregion

    #region Constructor
    
    public ChallengeService(DataContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Methods

    

    #endregion
}