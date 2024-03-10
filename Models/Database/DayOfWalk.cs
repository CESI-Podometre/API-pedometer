using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.DayOfWalk;

namespace StarFitApi.Models.Database;

[Table("DayOfWalk")]
[PrimaryKey(nameof(Date), nameof(UserId))]
public class DayOfWalk : IBaseModel<DayOfWalk, DayOfWalkCreateDto, DayOfWalkUpdateDto>
{
    public DayOfWalk() { }
    
    public static DayOfWalk Create(DayOfWalkCreateDto dayOfWalkCreateDto)
    {
        return new DayOfWalk
        {
            Date = dayOfWalkCreateDto.Date,
            Steps = dayOfWalkCreateDto.Steps,
            UserId = dayOfWalkCreateDto.UserId
        };
    }
    
    public DayOfWalk Update(DayOfWalkUpdateDto dayOfWalkUpdateDto)
    {
        Date = dayOfWalkUpdateDto.Date;
        Steps = dayOfWalkUpdateDto.Steps;
        UserId = dayOfWalkUpdateDto.UserId;
        return this;
    }

    public static DbSet<DayOfWalk> GetDbSet(DataContext context)
    {
        return context.DaysOfWalk;
    }
    
    [Column("date")]
    public DateTime Date { get; set; }

    [Column("steps")]
    public int Steps { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;
}