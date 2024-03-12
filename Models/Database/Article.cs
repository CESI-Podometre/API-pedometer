using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.Article;

namespace StarFitApi.Models.Database;

[Table("Articles")]
public class Article : IBaseModel<Article, ArticleCreateDto, ArticleUpdateDto>
{
    public Article() { }
    
    public static Article Create(ArticleCreateDto articleCreateDto)
    {
        return new Article
        {
            Title = articleCreateDto.Title,
            Description = articleCreateDto.Description,
            IllustrationPath = articleCreateDto.ImagePath,
            StartDate = articleCreateDto.StartDate,
            EndDate = articleCreateDto.EndDate,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public Article Update(ArticleUpdateDto articleUpdateDto)
    {
        Title = articleUpdateDto.Title;
        Description = articleUpdateDto.Description;
        IllustrationPath = articleUpdateDto.ImagePath;
        StartDate = articleUpdateDto.StartDate;
        EndDate = articleUpdateDto.EndDate;
        UpdatedAt = DateTime.Now;
        return this;
    }
    
    public static DbSet<Article> GetDbSet(DataContext context)
    {
        return context.Articles;
    }
    
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Column("title")]
    [MaxLength(50)]
    public string Title { get; set; } = null!;
    
    [Column("description")]
    [MaxLength(255)]
    public string Description { get; set; } = null!;
    
    [Column("illustration_path")]
    [MaxLength(255)]
    public string IllustrationPath { get; set; } = null!;
    
    [Column("published")]
    public bool Published { get; set; }
    
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    
    [Column("end_date")]
    public DateTime? EndDate { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}