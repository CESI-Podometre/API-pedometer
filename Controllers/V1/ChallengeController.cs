using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.ChallengeServices;
using StarFitApi.Services.FileServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/challenges")]
[ApiVersion("1.0")]
public class ChallengeController : ControllerBaseExtended<Challenge, ChallengeCreateDto, ChallengeUpdateDto, IChallengeService>
{
    #region Fields

    private readonly IChallengeService _challengeService;
    private readonly IFileService _fileService;

    #endregion
    
    #region Constructor
    
    public ChallengeController(IChallengeService challengeService, IFileService fileService) : base(challengeService)
    {
        _challengeService = challengeService;
        _fileService = fileService;
    }
    
    #endregion
    
    #region Methods
    
    [HttpGet("user-content")]
    [Authorize("user")]
    public async Task<IActionResult> GetUserContent()
    {
        return await TryExecuteControllerTask(async () =>
        {
            var id = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "id")?.Value ?? throw new Exception("User id not found"));
            return await _challengeService.GetUserContent(id);
        });
    }
    
    [HttpPost]
    [Authorize("admin")]
    public override async Task<IActionResult> Create([FromForm] ChallengeCreateDto createDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            if (createDto.Image == null) throw new Exception("Image is required");
            createDto.ImagePath = await _fileService.AddDocument(createDto.Image);
            
            await ValidateDto(createDto);
            return await _challengeService.Create(createDto);
        });
    }
    
    [HttpPut("{id:guid}")]
    [Authorize("admin")]
    public override async Task<IActionResult> Update(Guid id, [FromForm] ChallengeUpdateDto updateDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _challengeService.GetById(id);
            
            if (updateDto.Image != null) updateDto.ImagePath = await _fileService.UpdateDocument(updateDto.Image, badge.IllustrationPath);
            
            await ValidateDto(updateDto);
            return await _challengeService.Update(id, updateDto);
        });
    }
    
    [HttpDelete]
    [Authorize("admin")]
    public override async Task<IActionResult> Delete(Guid id)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _challengeService.GetById(id);
            
            _fileService.DeleteDocument(badge.IllustrationPath);
            return await _challengeService.Delete(id);
        });
    }
    
    #endregion
}