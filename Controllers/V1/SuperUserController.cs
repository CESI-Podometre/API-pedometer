using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.SuperUser;
using StarFitApi.Models.Dto.User;
using StarFitApi.Services.SuperUserServices;
using StarFitApi.Services.UserServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/super-users")]
[ApiVersion("1.0")]
public class SuperUserController : ControllerBaseExtended<SuperUser, SuperUserCreateDto, SuperUserUpdateDto, ISuperUserService>
{
    #region Fields

    private readonly ISuperUserService _superUserService;

    #endregion

    #region Constructor

    public SuperUserController(ISuperUserService superUserService) : base(superUserService)
    {
        _superUserService = superUserService;
    }

    #endregion

    #region Methods
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(SuperUserLoginDto superUserLoginDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            await ValidateDto(superUserLoginDto);
            return await _superUserService.Login(superUserLoginDto);
        });
    }

    [HttpGet]
    [Authorize("superAdmin")]
    public override Task<IActionResult> GetAll() => base.GetAll();
    
    [HttpPost]
    [Authorize("superAdmin")]
    public override Task<IActionResult> Create(SuperUserCreateDto createDto) => base.Create(createDto);
    
    [HttpPut]
    [Authorize("superAdmin")]
    public override Task<IActionResult> Update(Guid id, SuperUserUpdateDto updateDto) => base.Update(id, updateDto);
    
    [HttpDelete]
    [Authorize("superAdmin")]
    public override Task<IActionResult> Delete(Guid id) => base.Delete(id);

    #endregion
}