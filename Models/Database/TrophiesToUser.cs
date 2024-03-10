using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarFitApi.Models.Database;

[Table("TrophiesToUser")]
[PrimaryKey(nameof(UserId), nameof(TrophyId))]
public class TrophiesToUser
{
    [Column("user_id")]
    public Guid UserId { get; set; }
    
    [Column("trophy_id")]
    public Guid TrophyId { get; set; }
    
    [Column("obtained_at")]
    public DateTime ObtainedAt { get; init; }
    
    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;
    
    [ForeignKey(nameof(TrophyId))]
    public Trophy Trophy { get; set; } = null!;
}