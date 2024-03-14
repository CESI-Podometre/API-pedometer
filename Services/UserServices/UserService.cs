using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
using StarFitApi.Models.Exception;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.UserServices;

public class UserService : BaseService<User, UserCreateDto, UserUpdateDto>, IUserService
{
    #region MyRegion

    public UserService(DataContext context, IConfiguration configuration) : base(context)
    {
        _context = context;
        _config = configuration;
    }

    #endregion

    #region MyRegion

    private readonly DataContext _context;
    private readonly IConfiguration _config;

    #endregion

    #region Methods
    
    public async Task<User?> GetByIdentifier(string identifier)
    {
        return await _context.Users
            .Include(u => u.DaysOfWalk)
            .Include(u => u.BadgesToUsers)
            .ThenInclude(btu => btu.Badge)
            .FirstOrDefaultAsync(u => u.Identifier == identifier);
    }
    
    public async Task<User?> Me(string identifier)
    {
        return await _context.Users
            .Select(u => new {
                user = u,
                badges = _context.BadgesToUser
                    .Where(btu => btu.UserId == u.Id)
                    .Include(btu => btu.Badge)
                    .Select(btu => btu.Badge)
                    .ToList(),
                daysOfWalk = _context.DaysOfWalk
                    .Where(dow => dow.UserId == u.Id)
                    .ToList()
            })
            .Select(objects => new User
            {
                Id = objects.user.Id,
                Identifier = objects.user.Identifier,
                CreatedAt = objects.user.CreatedAt,
                UpdatedAt = objects.user.UpdatedAt,
                Badges = objects.badges,
                DaysOfWalk = objects.daysOfWalk
            })
            .FirstOrDefaultAsync(u => u.Identifier == identifier);
    }

    public async Task<TokenResponse?> Login(UserLoginDto userLoginDto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Identifier == userLoginDto.Identifier);
        if (user == null) throw new NotFoundException("User not found");

        var key = _config.GetSection("Jwt:Key").Get<string>() ?? throw new Exception("Jwt:Key not found in appsettings.json");
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim("id", user.Id.ToString()),
            new Claim("name", user.Identifier),
            new Claim("role", "user")
        };

        var token = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims,
            expires: DateTime.Now.AddMonths(1),
            signingCredentials: credentials
        );

        return new TokenResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expires = token.ValidTo
        };
    }

    public async Task<User?> GetStats(string identifier, DateTime? startDate, DateTime? endDate)
    {
        var user = await _context.Users
            .Select(u => new {
                user = u,
                dows = _context.DaysOfWalk
                    .Where(dow => dow.UserId == u.Id)
                    .Where(dow => startDate == null || ((DateTime)startDate).Date <= dow.Date)
                    .Where(dow => endDate == null || ((DateTime)endDate).Date >= dow.Date)
                    .ToList()
            })
            .Select(objects => new User
            {
                Id = objects.user.Id,
                Identifier = objects.user.Identifier,
                CreatedAt = objects.user.CreatedAt,
                UpdatedAt = objects.user.UpdatedAt,
                DaysOfWalk = objects.dows,
            })
            .FirstOrDefaultAsync(u => u.Identifier == identifier);
        if (user == null) throw new NotFoundException("User not found");
        user.FixDaysOfWalk(startDate, endDate);
        return user;
    }

    public async Task<IEnumerable<User>> GetAllWithData()
    {
        return await _context.Users
            .Select(u => new {
                user = u,
                badges = _context.BadgesToUser
                    .Where(btu => btu.UserId == u.Id)
                    .Include(btu => btu.Badge)
                    .Select(btu => btu.Badge)
                    .ToList(),
                daysOfWalk = _context.DaysOfWalk
                    .Where(dow => dow.UserId == u.Id)
                    .ToList()
            })
            .Select(objects => new User
            {
                Id = objects.user.Id,
                Identifier = objects.user.Identifier,
                CreatedAt = objects.user.CreatedAt,
                UpdatedAt = objects.user.UpdatedAt,
                Badges = objects.badges,
                DaysOfWalk = objects.daysOfWalk
            })
            .ToListAsync();
    }

    #endregion
}