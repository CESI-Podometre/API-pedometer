using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.UserServices;

public interface IUserService : IBaseService<User, UserCreateDto, UserUpdateDto>
{
    public Task<User?> GetByIdentifier(string identifier);
    public Task<User?> Me(string identifier);
    public Task<TokenResponse?> Login(UserLoginDto userLoginDto);
    public Task<User?> GetStats(string identifier, DateTime? startDate, DateTime? endDate);
}