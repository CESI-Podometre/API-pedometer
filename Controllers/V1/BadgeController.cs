using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.BadgeServices;
using StarFitApi.Services.ChallengeServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/badges")]
[ApiVersion("1.0")]
public class BadgeController : ControllerBaseExtended<Badge, BadgeCreateDto, BadgeUpdateDto, IBadgeService>
{
    #region Fields

    private readonly IChallengeService _challengeService;

    #endregion
    
    #region Constructor
    
    public BadgeController(IBadgeService badgeService, IChallengeService challengeService) : base(badgeService)
    {
        _challengeService = challengeService;
    }
    
    #endregion
    
    #region Methods
    
    
    #endregion
}