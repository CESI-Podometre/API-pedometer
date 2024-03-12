using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
using StarFitApi.Models.Exception;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.UserServices;

public class UserService : BaseService<User, UserCreateDto, UserUpdateDto>, IUserService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public UserService(DataContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Methods

    public async Task<User?> GetByIdentifier(string identifier)
    {
        var user = await _context.Users
            .Include(u => u.DaysOfWalk)
            .Include(u => u.BadgesToUsers)
            .ThenInclude(btu => btu.Badge)
            .FirstOrDefaultAsync(u => u.Identifier == identifier);
        if (user == null) throw new NotFoundException("User not found");
        user.FixDaysOfWalk();
        return user;
    }

    public async Task<User?> GetStat(string identifier)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Identifier == identifier);
    }

    #endregion
}