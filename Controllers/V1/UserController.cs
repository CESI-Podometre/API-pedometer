using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
using StarFitApi.Services.UserServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/users")]
[ApiVersion("1.0")]
public class UserController : ControllerBaseExtended<User, UserCreateDto, UserUpdateDto, IUserService>
{
    #region Fields

    private readonly IUserService _userService;

    #endregion

    #region Constructor

    public UserController(IUserService userService) : base(userService)
    {
        _userService = userService;
    }

    #endregion

    #region Methods

    [Authorize("admin")]
    [HttpGet("{identifier}")]
    public async Task<IActionResult> GetById(string identifier)
    {
        return await TryExecuteControllerTask(async () => await _userService.GetByIdentifier(identifier));
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginDto userLoginDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            await ValidateDto(userLoginDto);
            return await _userService.Login(userLoginDto);
        });
    }
    
    [HttpGet("{identifier}/stats")]
    [Authorize("admin")]
    public async Task<IActionResult> GetUserStatsByIdentifier(string identifier, DateTime? startDate, DateTime? endDate)
    {
        return await TryExecuteControllerTask(async () => await _userService.GetStats(identifier, startDate, endDate));
    }
    
    #endregion
}