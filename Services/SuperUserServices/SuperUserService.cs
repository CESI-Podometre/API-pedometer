using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.SuperUser;
using StarFitApi.Models.Exception;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.SuperUserServices;

public class SuperUserService : BaseService<SuperUser, SuperUserCreateDto, SuperUserUpdateDto>, ISuperUserService
{
    #region MyRegion

    private readonly DataContext _context;
    private readonly IConfiguration _config;

    #endregion

    #region MyRegion

    public SuperUserService(DataContext context, IConfiguration configuration) : base(context)
    {
        _context = context;
        _config = configuration;
    }

    #endregion

    #region Methods

    public override async Task<SuperUser> Create(SuperUserCreateDto createDto)
    {
        createDto.Password = BCrypt.Net.BCrypt.HashPassword(createDto.Password, 5);
        return await base.Create(createDto);
    }

    public async Task<TokenResponse?> Login(SuperUserLoginDto superUserLoginDto)
    {
        var superUser = await _context.SuperUsers.FirstOrDefaultAsync(su => su.Username == superUserLoginDto.Username);
        if (superUser == null) throw new NotFoundException("Super User not found");
        
        if (!BCrypt.Net.BCrypt.Verify(superUserLoginDto.Password, superUser.Password)) throw new Exception("Invalid password");
        
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, superUser.Username),
            new Claim(ClaimTypes.Role, superUser.SuperRole)
        };
        
        var token = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims,
            expires: DateTime.Now.AddMinutes(120),
            signingCredentials: credentials
        );
        
        return new TokenResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expires = token.ValidTo
        };
    }

    #endregion
}