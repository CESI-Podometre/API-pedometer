using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.User;

namespace StarFitApi.Models.Database;

[Table("Users")]
[Index(nameof(Email), IsUnique = true)]
public class User : IBaseModel<User, UserCreateDto, UserUpdateDto>
{
    public User() {}
    
    public static User Create(UserCreateDto userCreateDto)
    {
        return new User
        {
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName,
            Email = userCreateDto.Email,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public User Update(UserUpdateDto userUpdateDto)
    {
        FirstName = userUpdateDto.FirstName;
        LastName = userUpdateDto.LastName;
        Email = userUpdateDto.Email;
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
    
    [Column("first_name")]
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    
    [Column("last_name")]
    [MaxLength(50)]
    public string LastName { get; set; } = null!;
    
    [Column("email")]
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    public IEnumerable<BadgesToUser> BadgesToUsers { get; set; } = null!;
    
    public IEnumerable<Badge> Badges { get; set; } = null!;
    
    public IEnumerable<DayOfWalk> DaysOfWalk { get; set; } = null!;
}