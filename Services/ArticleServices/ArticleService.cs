using StarFitApi.Models;
using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Article;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Services.BadgeServices;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.ArticleServices;

public class ArticleService : BaseService<Article, ArticleCreateDto, ArticleUpdateDto>, IArticleService
{
    #region MyRegion

    private readonly DataContext _context;

    #endregion

    #region MyRegion

    public ArticleService(DataContext context) : base(context)
    {
        _context = context;
    }
    
    #endregion

    #region Methods

    

    #endregion
}