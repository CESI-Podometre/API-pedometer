using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto.SuperUser;
using StarFitApi.Models.Dto.User;

namespace StarFitApi.Models.Database;

[Table("SuperUsers")]
[Index(nameof(Username), IsUnique = true)]
public class SuperUser : IBaseModel<SuperUser, SuperUserCreateDto, SuperUserUpdateDto>
{
    public SuperUser() {}
    
    public static SuperUser Create(SuperUserCreateDto superUserCreateDto)
    {
        return new SuperUser
        {
            Username = superUserCreateDto.Username,
            Password = superUserCreateDto.Password,
            SuperRole = "admin",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    
    public SuperUser Update(SuperUserUpdateDto superUserUpdateDto)
    {
        Username = superUserUpdateDto.Username;
        UpdatedAt = DateTime.Now;
        return this;
    }
    
    public static DbSet<SuperUser> GetDbSet(DataContext context)
    {
        return context.SuperUsers;
    }
    
    [Column("id")]
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    
    [Column("username")]
    [MaxLength(50)]
    public string Username { get; set; } = null!;
    
    [Column("password")]
    [MaxLength(120)]
    [JsonIgnore]
    public string Password { get; set; } = null!;
    
    [Column("super_role")]
    public string SuperRole { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}