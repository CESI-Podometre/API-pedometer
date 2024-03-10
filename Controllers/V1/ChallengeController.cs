using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.ChallengeServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/challenges")]
[ApiVersion("1.0")]
public class ChallengeController : ControllerBaseExtended<Challenge, ChallengeCreateDto, ChallengeUpdateDto, IChallengeService>
{
    #region Fields

    private readonly IChallengeService _challengeService;

    #endregion
    
    #region Constructor
    
    public ChallengeController(IChallengeService challengeService) : base(challengeService)
    {
        _challengeService = challengeService;
    }
    
    #endregion
    
    #region Methods
    
    
    #endregion
}