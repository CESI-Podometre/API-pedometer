using Asp.Versioning;
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

    [HttpGet("identifier/{identifier}")]
    public async Task<IActionResult> GetByIdentifier(string identifier)
    {
        return await TryExecuteControllerTask(async () => await _userService.GetByIdentifier(identifier));
    }
    
    #endregion
}