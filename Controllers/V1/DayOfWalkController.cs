using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Services.DayOfWalkServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/day-of-walks")]
[ApiVersion("1.0")]
public class DayOfWalkController : ControllerBaseExtended<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto, IDayOfWalkService>
{
    #region Fields

    private readonly IDayOfWalkService _dayOfWalkService;

    #endregion
    
    #region Constructor
    
    public DayOfWalkController(IDayOfWalkService dayOfWalkService) : base(dayOfWalkService)
    {
        _dayOfWalkService = dayOfWalkService;
    }
    
    #endregion
    
    #region Methods
    
    #endregion
}