using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Models.Dto.Trophy;
using StarFitApi.Services.ChallengeServices;
using StarFitApi.Services.TrophyServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/trophies")]
[ApiVersion("1.0")]
public class TrophyController : ControllerBaseExtended<Trophy, TrophyCreateDto, TrophyUpdateDto, ITrophyService>
{
    #region Fields

    private readonly IChallengeService _challengeService;

    #endregion
    
    #region Constructor
    
    public TrophyController(ITrophyService trophyService, IChallengeService challengeService) : base(trophyService)
    {
        _challengeService = challengeService;
    }
    
    #endregion
    
    #region Methods
    
    
    #endregion
}