

using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.DayOfWalk;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.DayOfWalkServices;

public class DayOfWalkService : BaseService<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>, IDayOfWalkService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public DayOfWalkService(DataContext context) : base(context)
    {
        _context = context;
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

    #endregion
}

