using StarFitApi.Models.Database;
using StarFitApi.Models.Dto.Article;
using StarFitApi.Models.Dto.Badge;
using StarFitApi.Services.BaseServices;

namespace StarFitApi.Services.ArticleServices;

public interface IArticleService : IBaseService<Article, ArticleCreateDto, ArticleUpdateDto>
{
    public Task<IEnumerable<Article>> GetUserContent();
}