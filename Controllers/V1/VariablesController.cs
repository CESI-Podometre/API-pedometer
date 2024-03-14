using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Services.VariablesServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/variables")]
[ApiVersion("1.0")]
public class VariablesController : ControllerBase
{
    #region Fields

    private readonly IVariablesService _variablesService;

    #endregion
    
    #region Constructor
    
    public VariablesController(IVariablesService variablesService)
    {
        _variablesService = variablesService;
    }
    
    #endregion
    
    #region Methods
    
    [HttpGet("{property}")]
    [Authorize("admin")]
    public async Task<IActionResult> GetVariable(string property)
    {
        try
        {
            var variable = await _variablesService.GetVariable(property);
            return Ok(variable);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPatch("{property}")]
    [Authorize("admin")]
    public async Task<IActionResult> PatchVariable(string property, string value)
    {
        try
        {
            var variable = await _variablesService.PatchVariable(property, value);
            return Ok(variable);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    #endregion
}