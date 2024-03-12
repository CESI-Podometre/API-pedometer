using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
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
    
    [JsonIgnore]
    public IEnumerable<BadgesToUser> BadgesToUsers { get; set; } = null!;

    [NotMapped]
    public IEnumerable<Badge> Badges
    {
        get { return BadgesToUsers.Select(btu => btu.Badge); }
    }
    public IEnumerable<DayOfWalk> DaysOfWalk { get; set; } = null!;

    public void FixDaysOfWalk()
    {
        DaysOfWalk = DaysOfWalk.OrderBy(dow => dow.Date).ToList();
        FillDaysOfWalk(DaysOfWalk.Last().Date);
    }
    
    private void FillDaysOfWalk(DateTime lastDay, int index = 0)
    {
        var dayOfWalk = DaysOfWalk.ElementAt(index);
        if (dayOfWalk.Date.Date == lastDay.Date) return;
        var nextDayOfWalk = DaysOfWalk.ElementAt(index + 1);
        if (dayOfWalk.Date.AddDays(1).Date != nextDayOfWalk.Date.Date)
        {
            DaysOfWalk = DaysOfWalk.Take(index + 1)
                .Concat(new List<DayOfWalk> {new DayOfWalk {Date = dayOfWalk.Date.AddDays(1), UserId = dayOfWalk.UserId, Steps = 0}})
                .Concat(DaysOfWalk.Skip(index + 1))
                .ToList();
            FillDaysOfWalk(lastDay, index + 1);
        }
        else FillDaysOfWalk(lastDay, index + 1);
    }
    
    
}