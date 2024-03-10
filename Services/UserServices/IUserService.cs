using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.UserServices;

public interface IUserService : IBaseService<User, UserCreateDto, UserUpdateDto> { }