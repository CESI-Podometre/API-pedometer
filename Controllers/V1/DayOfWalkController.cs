using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
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
    
    [HttpPost("user-create-or-update")]
    [Authorize("user")]
    public async Task<IActionResult> UserCreateOrUpdate(DayOfWalkUserCreateOrUpdateDto dayOfWalkUserCreateOrUpdateDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var id = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "identifier")?.Value!);
            return await _dayOfWalkService.UserCreateOrUpdate(id, dayOfWalkUserCreateOrUpdateDto);
        });
    }
    
    #endregion
}