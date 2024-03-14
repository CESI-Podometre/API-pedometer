using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Helpers;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Article;
using StarFitApi.Services.ArticleServices;
using StarFitApi.Services.FileServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/articles")]
[ApiVersion("1.0")]
public class ArticleController : ControllerBaseExtended<Article, ArticleCreateDto, ArticleUpdateDto, IArticleService>
{
    #region Fields

    private readonly IArticleService _articleService;
    private readonly IFileService _fileService;

    #endregion
    
    #region Constructor
    
    public ArticleController(IArticleService articleService, IFileService fileService) : base(articleService)
    {
        _articleService = articleService;
        _fileService = fileService;
    }
    
    #endregion
    
    #region Methods
    
    [HttpGet("user-content")]
    [Authorize("user")]
    public async Task<IActionResult> GetUserContent()
    {
        return await TryExecuteControllerTask(async () => await _articleService.GetUserContent());
    }
    
    [HttpPost]
    [Authorize("admin")]
    public override async Task<IActionResult> Create([FromForm] ArticleCreateDto createDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            if (createDto.Image == null) throw new Exception("Image is required");
            if (createDto.File == null) throw new Exception("File is required");
            createDto.ImagePath = await _fileService.AddDocument(createDto.Image);
            createDto.FilePath = await _fileService.AddDocument(createDto.File);
            
            await ValidateDto(createDto);
            return await _articleService.Create(createDto);
        });
    }
    
    [HttpPut("{id:guid}")]
    [Authorize("admin")]
    public override async Task<IActionResult> Update(Guid id, [FromForm] ArticleUpdateDto updateDto)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _articleService.GetById(id);
            
            if (updateDto.Image != null) updateDto.ImagePath = await _fileService.UpdateDocument(updateDto.Image, badge.IllustrationPath);
            if (updateDto.File != null) updateDto.FilePath = await _fileService.UpdateDocument(updateDto.File, badge.FilePath);
            
            await ValidateDto(updateDto);
            return await _articleService.Update(id, updateDto);
        });
    }
    
    [HttpPatch("{id:guid}/publish")]
    [Authorize("admin")]
    public async Task<IActionResult> UpdatePublishState(Guid id, bool state)
    {
        return await TryExecuteControllerTask(async () => await _articleService.UpdatePublishState(id, state));
    }
    
    [HttpDelete]
    [Authorize("admin")]
    public override async Task<IActionResult> Delete(Guid id)
    {
        return await TryExecuteControllerTask(async () =>
        {
            var badge = await _articleService.GetById(id);
            
            _fileService.DeleteDocument(badge.IllustrationPath);
            _fileService.DeleteDocument(badge.FilePath);
            return await _articleService.Delete(id);
        });
    }
    
    #endregion
}