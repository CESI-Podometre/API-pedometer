using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Challenge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.ChallengeServices;

public class ChallengeService : BaseService<Challenge, ChallengeCreateDto, ChallengeUpdateDto>, IChallengeService
{
    #region Fields

    private readonly DataContext _context;

    #endregion

    #region Constructor
    
    public ChallengeService(DataContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Methods

    public async Task<IEnumerable<Challenge>> GetUserContent(Guid id)
    {
        return await _context.Challenges
            .Where(c => c.StartDate <= DateTime.Now)
            .Where(c => c.EndDate == null || c.EndDate >= DateTime.Now)
            .Include(c => c.Badge)
            .Select(c => new Challenge
            {
                Id = c.Id,
                BadgeId = c.BadgeId,
                Title = c.Title,
                Description = c.Description,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                IsGlobal = c.IsGlobal,
                IllustrationPath = c.IllustrationPath,
                Objective = c.Objective,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                Badge = c.Badge,
                Progression = _context.DaysOfWalk
                    .Where(dow => c.IsGlobal || dow.UserId == id)
                    .Where(dow => c.StartDate <= dow.Date)
                    .Where(dow => c.EndDate == null || c.EndDate >= dow.Date)
                    .Select(dow => dow.Steps)
                    .Sum()
            })
            .ToListAsync();
    }

    #endregion
}