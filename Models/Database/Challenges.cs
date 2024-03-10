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
        Objective = challengeUpdateDto.Objective;
        return this;
    }

    public static DbSet<Challenge> GetDbSet(DataContext context)
    {
        return context.Challenges;
    }


    [Column("id")]
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    
    [Column("trophy_id")]
    public Guid TrophyId { get; set; }
    
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
    public DateTime UpdatedAt { get; init; }
    
    [ForeignKey("TrophyId")]
    public Trophy Trophy { get; set; } = null!;
}