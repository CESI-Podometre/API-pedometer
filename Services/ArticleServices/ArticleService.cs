using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    
    public async Task<IEnumerable<Article>> GetUserContent()
    {
        return await _context.Articles
            .Where(a => a.Published)
            .Where(a => a.StartDate <= DateTime.Now)
            .Where(a => a.EndDate >= DateTime.Now)
            .ToListAsync();
    }

    #endregion
}