using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.Trophy;

namespace StarFitApi.Models.Database;

[Table("Trophies")]
public class Trophy : IBaseModel<Trophy, TrophyCreateDto, TrophyUpdateDto>
{
    public Trophy() { }
    
    public static Trophy Create(TrophyCreateDto trophyCreateDto)
    {
        return new Trophy
        {
            Title = trophyCreateDto.Title,
            Description = trophyCreateDto.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public Trophy Update(TrophyUpdateDto trophyUpdateDto)
    {
        Title = trophyUpdateDto.Title;
        Description = trophyUpdateDto.Description;
        UpdatedAt = DateTime.Now;
        return this;
    }
    
    public static DbSet<Trophy> GetDbSet(DataContext context)
    {
        return context.Trophies;
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
    
    [Column("icon_path")]
    [MaxLength(255)]
    public string IconPath { get; set; } = null!;
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    public IEnumerable<Challenge> Challenges { get; set; } = null!;
}