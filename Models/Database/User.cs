using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StarFitApi.Models.Dto.User;

namespace StarFitApi.Models.Database;

[Table("Users")]
[Index(nameof(Identifier), IsUnique = true)]
public class User : IBaseModel<User, UserCreateDto, UserUpdateDto>
{
    public User() {}
    
    public static User Create(UserCreateDto userCreateDto)
    {
        return new User
        {
            Identifier = userCreateDto.Identifier,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public User Update(UserUpdateDto userUpdateDto)
    {
        Identifier = userUpdateDto.Identifier;
        UpdatedAt = DateTime.Now;
        return this;
    }
    
    public static DbSet<User> GetDbSet(DataContext context)
    {
        return context.Users;
    }
    
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Column("identifier")]
    [MaxLength(50)]
    public string Identifier { get; set; } = null!;
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [NotMapped]
    public int TotalSteps => DaysOfWalk?.Sum(dow => dow.Steps) ?? 0;

    public IEnumerable<BadgesToUser> BadgesToUsers { get; init; } = new List<BadgesToUser>();

    public IEnumerable<Badge> Badges { get; init; } = new List<Badge>();

    public IEnumerable<DayOfWalk>? DaysOfWalk { get; set; }

    public void FixDaysOfWalk(DateTime? firstDay = null, DateTime? lastDay = null)
    {
        if (DaysOfWalk == null || !DaysOfWalk.Any())
            DaysOfWalk = new List<DayOfWalk>() { new DayOfWalk { UserId = Id, Date = firstDay?.Date ?? DateTime.Now, Steps = 0 } };
        firstDay ??= DaysOfWalk.Min(dow => dow.Date);
        lastDay ??= DaysOfWalk.Max(dow => dow.Date);
        DaysOfWalk = DaysOfWalk.OrderBy(dow => dow.Date).ToList();
        if (DaysOfWalk.First().Date.Date != firstDay.Value.Date.Date)
        {
            DaysOfWalk = DaysOfWalk.Prepend(new DayOfWalk
            {
                UserId = Id,
                Date = firstDay.Value.Date,
                Steps = 0
            });
        }
        FillMissingDays(lastDay.Value.Date);
    }
    
    private void FillMissingDays(DateTime lastDay, int index = 0)
    {
        if (DaysOfWalk == null) return;
        if (DaysOfWalk.Count() <= index + 1) return;
        var currentDay = DaysOfWalk.ElementAt(index).Date.Date;
        var nextDay = DaysOfWalk.ElementAt(index + 1).Date.Date;
        var supposedNextDay = currentDay.AddDays(1);
        if (nextDay != supposedNextDay)
        {
            DaysOfWalk = DaysOfWalk.Take(index + 1).Concat(new List<DayOfWalk>
            {
                new()
                {
                    UserId = Id,
                    Date = supposedNextDay,
                    Steps = 0
                }
            }).Concat(DaysOfWalk.Skip(index + 1)).ToList();
        }
        if (supposedNextDay.Date != lastDay.Date) FillMissingDays(lastDay, index + 1);
    }
}