using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Database;

namespace StarFitApi.Models;

public class DataContext : DbContext
{
    #region Constructor

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>();
        modelBuilder.Entity<DayOfWalk>();
        
        modelBuilder.Entity<Challenge>();
        modelBuilder.Entity<Badge>();
        modelBuilder.Entity<BadgesToUser>();
    }
    
    public required DbSet<User> Users { get; set; }
    public required DbSet<DayOfWalk> DaysOfWalk { get; set; }
    
    public required DbSet<Challenge> Challenges { get; set; }
    public required DbSet<Badge> Badges { get; set; }
    public required DbSet<BadgesToUser> BadgesToUser { get; set; }
}