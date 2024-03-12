using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarFitApi.Models.Database;

[Table("BadgesToUser")]
[PrimaryKey(nameof(UserId), nameof(BadgeId))]
public class BadgesToUser
{
    [Column("user_id")]
    public Guid UserId { get; set; }
    
    [Column("badge_id")]
    public Guid BadgeId { get; set; }
    
    [Column("obtained_at")]
    public DateTime ObtainedAt { get; init; }
    
    [ForeignKey(nameof(UserId))]
    public User User { get; init; } = null!;
    
    [ForeignKey(nameof(BadgeId))]
    public Badge Badge { get; init; } = null!;
}