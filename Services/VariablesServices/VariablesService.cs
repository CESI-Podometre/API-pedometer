using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Exception;

namespace StarFitApi.Services.VariablesServices;

public class VariablesService : IVariablesService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public VariablesService(DataContext context)
    {
        _context = context;
    }
    
    #endregion

    #region Methods
    
    public async Task<string> GetVariable(string property)
    {
        var variables = await _context.Variables.FirstOrDefaultAsync();
        if (variables == null) throw new NotFoundException("Variable not found");
        
        var variable = variables.GetType().GetProperty(property)?.GetValue(variables, null)?.ToString();
        if (variable == null) throw new NotFoundException("Variable not found");
        
        return variable;
    }
    
    public async Task<string> PatchVariable(string property, string value)
    {
        var variables = await _context.Variables.FirstOrDefaultAsync();
        if (variables == null) throw new NotFoundException("Variable not found");
        
        var propertyInfo = variables.GetType().GetProperty(property);
        if (propertyInfo == null) throw new NotFoundException("Variable not found");
        
        propertyInfo.SetValue(variables, value);
        await _context.SaveChangesAsync();
        
        return value;
    }

    #endregion
}