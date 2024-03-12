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

    public async Task<TokenResponse?> Login(UserLoginDto userLoginDto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Identifier == userLoginDto.Identifier);
        if (user == null) throw new NotFoundException("User not found");

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Identifier),
            new Claim(ClaimTypes.Role, "user")
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
            .Include(u => u.DaysOfWalk!.Where(
                dow =>
                    (startDate == null || dow.Date >= startDate) &&
                    (endDate == null || dow.Date <= endDate)
            ))
            .FirstOrDefaultAsync(u => u.Identifier == identifier);
        if (user == null) throw new NotFoundException("User not found");
        user.FixDaysOfWalk();
        return user;
    }

    #endregion
}