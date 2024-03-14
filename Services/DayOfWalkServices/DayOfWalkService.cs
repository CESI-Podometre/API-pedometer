

using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;
using StarFitApi.Services.VariablesServices;

namespace StarFitApi.Services.DayOfWalkServices;

public class DayOfWalkService : BaseService<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>, IDayOfWalkService
{
    #region MyRegion

    private readonly DataContext _context;
    private readonly IVariablesService _variablesService;

    #endregion

    #region MyRegion

    public DayOfWalkService(DataContext context, IVariablesService variablesService) : base(context)
    {
        _context = context;
        _variablesService = variablesService;
    }
    
    #endregion

    #region Methods

    public async Task<DayOfWalk> UserCreateOrUpdate(Guid id, DayOfWalkUserCreateOrUpdateDto dayOfWalkUserCreateOrUpdateDto)
    {
        var dayOfWalk = await _context.DaysOfWalk
            .FirstOrDefaultAsync(dow => dow.UserId == id && dow.Date == dayOfWalkUserCreateOrUpdateDto.Date);
        if (dayOfWalk == null)
        {
            dayOfWalk = new DayOfWalk
            {
                UserId = id,
                Date = dayOfWalkUserCreateOrUpdateDto.Date,
                Steps = dayOfWalkUserCreateOrUpdateDto.Steps
            };
            await _context.DaysOfWalk.AddAsync(dayOfWalk);
        }
        else dayOfWalk.Steps = dayOfWalkUserCreateOrUpdateDto.Steps;
        await _context.SaveChangesAsync();
        return dayOfWalk;
    }
    
    public async Task<GlobalProgression> GetGlobalProgression()
    {
        var conversionStepMoney = int.Parse(await _variablesService.GetVariable("ConversionStepMoney"));
        var daysOfWalk = await _context.DaysOfWalk.ToListAsync();
        var totalSteps = daysOfWalk.Sum(dow => dow.Steps);
        
        var globalProgression = new GlobalProgression
        {
            TotalSteps = totalSteps,
            TotalDays = daysOfWalk.DistinctBy(dow => dow.Date.Date).Count(),
            TotalMoney = totalSteps / conversionStepMoney,
            TotalKilometers = totalSteps * 65 / 100000,
        };
        return globalProgression;
    }

    #endregion
}

