using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Services.BadgeServices;
using StarFitApi.Services.FileServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/badges")]
[ApiVersion("1.0")]
public class BadgeController : ControllerBaseExtended<Badge, BadgeCreateDto, BadgeUpdateDto, IBadgeService>
{
    #region Fields

    private readonly IBadgeService _badgeService;
    private readonly IFileService _fileService;

    #endregion
    
    #region Constructor
    
    public BadgeController(IBadgeService badgeService, IFileService fileService) : base(badgeService)
    {
        _badgeService = badgeService;
        _fileService = fileService;
    }
    
    #endregion
    
    #region Methods

    [HttpGet("user-content")]
    [Authorize("user")]
    public async Task<IActionResult> GetUserContent()
    {
        return await TryExecuteControllerTask(async () => await _badgeService.GetAll());
    }

    [HttpPost]
    [Authorize("admin")]
    public override async Task<IActionResult> Create([FromForm] BadgeCreateDto createDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            if (createDto.Image == null) throw new Exception("Image is required");
            createDto.ImagePath = await _fileService.AddDocument(createDto.Image);
            
            await ValidateDto(createDto);
            return await _badgeService.Create(createDto);
        });
    }
    
    [HttpPut("{id:guid}")]
    [Authorize("admin")]
    public override async Task<IActionResult> Update(Guid id, [FromForm] BadgeUpdateDto updateDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _badgeService.GetById(id);
            
            if (updateDto.Image != null) updateDto.ImagePath = await _fileService.UpdateDocument(updateDto.Image, badge.IconPath);
            
            await ValidateDto(updateDto);
            return await _badgeService.Update(id, updateDto);
        });
    }
    
    [HttpDelete("{id:guid}")]
    [Authorize("admin")]
    public override async Task<IActionResult> Delete(Guid id)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _badgeService.GetById(id);
            _fileService.DeleteDocument(badge.IconPath);
            return await _badgeService.Delete(id);
        });
    }
    
    #endregion
}