using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.User;
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

    

    #endregion
}