using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.Challenge;

namespace StarFitApi.Models.Database;

[Table("Challenges")]
public class Challenge : IBaseModel<Challenge, ChallengeCreateDto, ChallengeUpdateDto>
{
    public Challenge() { }
    
    public static Challenge Create(ChallengeCreateDto challengeCreateDto)
    {
        return new Challenge
        {
            Title = challengeCreateDto.Title,
            Description = challengeCreateDto.Description,
            StartDate = challengeCreateDto.StartDate,
            EndDate = challengeCreateDto.EndDate,
            IsGlobal = challengeCreateDto.IsGlobal,
            Objective = challengeCreateDto.Objective,
            BadgeId = challengeCreateDto.BadgeId,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public Challenge Update(ChallengeUpdateDto challengeUpdateDto)
    {
        Title = challengeUpdateDto.Title;
        Description = challengeUpdateDto.Description;
        StartDate = challengeUpdateDto.StartDate;
        EndDate = challengeUpdateDto.EndDate;
        IsGlobal = challengeUpdateDto.IsGlobal;
        BadgeId = challengeUpdateDto.BadgeId;
        Objective = challengeUpdateDto.Objective;
        UpdatedAt = DateTime.Now;
        return this;
    }

    public static DbSet<Challenge> GetDbSet(DataContext context)
    {
        return context.Challenges;
    }


    [Column("id")]
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    
    [Column("badge_id")]
    public Guid BadgeId { get; set; }
    
    [Column("title")]
    [MaxLength(50)]
    public string Title { get; set; } = null!;
    
    [Column("description")]
    [MaxLength(255)]
    public string Description { get; set; } = null!;
    
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    
    [Column("end_date")]
    public DateTime? EndDate { get; set; }
    
    [Column("is_global")]
    public bool IsGlobal { get; set; }
    
    [Column("objective")]
    public int Objective { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [ForeignKey("BadgeId")]
    public Badge Badge { get; init; } = null!;
}