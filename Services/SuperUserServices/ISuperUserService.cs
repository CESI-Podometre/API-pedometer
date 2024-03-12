using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.SuperUser;
using StarFitApi.Models.Dto.User;
using StarFitApi.Models.Other;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.SuperUserServices;

public interface ISuperUserService : IBaseService<SuperUser, SuperUserCreateDto, SuperUserUpdateDto>
{
    public Task<TokenResponse?> Login(SuperUserLoginDto superUserLoginDto);
}