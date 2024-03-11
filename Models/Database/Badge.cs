using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.Badge;

namespace StarFitApi.Models.Database;

[Table("Badges")]
public class Badge : IBaseModel<Badge, BadgeCreateDto, BadgeUpdateDto>
{
    public Badge() { }
    
    public static Badge Create(BadgeCreateDto badgeCreateDto)
    {
        return new Badge
        {
            Title = badgeCreateDto.Title,
            Description = badgeCreateDto.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public Badge Update(BadgeUpdateDto badgeUpdateDto)
    {
        Title = badgeUpdateDto.Title;
        Description = badgeUpdateDto.Description;
        UpdatedAt = DateTime.Now;
        return this;
    }
    
    public static DbSet<Badge> GetDbSet(DataContext context)
    {
        return context.Badges;
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