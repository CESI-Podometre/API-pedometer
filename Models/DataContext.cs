using Microsoft.EntityFrameworkCore;
using StarFitApi.Helpers;
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
    
        var dataSeeder = new DataSeeder(modelBuilder);
        dataSeeder.Seed();
        // modelBuilder.Entity<BadgesToUser>();
        // modelBuilder.Entity<Badge>();
        // modelBuilder.Entity<Challenge>();
        // modelBuilder.Entity<Article>();
        // modelBuilder.Entity<DayOfWalk>();
        // modelBuilder.Entity<SuperUser>();
        // modelBuilder.Entity<User>();
    }
    
    public required DbSet<User> Users { get; set; }
    public required DbSet<SuperUser> SuperUsers { get; set; }
    public required DbSet<DayOfWalk> DaysOfWalk { get; set; }
    public required DbSet<Article> Articles { get; set; }
    
    public required DbSet<Challenge> Challenges { get; set; }
    public required DbSet<Badge> Badges { get; set; }
    public required DbSet<BadgesToUser> BadgesToUser { get; set; }
}