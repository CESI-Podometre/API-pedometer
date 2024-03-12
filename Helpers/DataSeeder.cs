using Microsoft.EntityFrameworkCore;
using StarFitApi.Models;
using StarFitApi.Models.Database;

namespace StarFitApi.Helpers;

public class DataSeeder
{
    #region Fields
    
    private readonly ModelBuilder _modelBuilder;
    private readonly List<string> _articleImages = new()
    {
        "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=",
        "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg",
        "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg"
    };
    private readonly List<string> _badgeImages = new()
    {
        "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg",
        "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png",
        "https://pngimg.com/uploads/cat/cat_PNG50447.png"
    };
    private List<User> _users = new();
    private List<DayOfWalk> _daysOfWalk = new();
    private List<Article> _articles = new();
    private List<Challenge> _challenges = new();
    private List<Badge> _badges = new();
    private List<BadgesToUser> _badgesToUsers = new();
    
    #endregion
    
    #region Constructor
    
    public DataSeeder(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    
    #endregion
    
    #region Methods
    
    private void GenerateUsers()
    {
        for (var i = 0; i < 10; i++)
        {
            var guid = Guid.NewGuid();
            var user = new User
            {
                Id = guid,
                Identifier = $"user{i}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _users.Add(user);
        }
        _modelBuilder.Entity<User>().HasData(_users);
    }
    
    private void GenerateDaysOfWalk()
    {
        for (var i = 0; i < 100; i++)
        {
            var dayOfWalk = new DayOfWalk
            {
                UserId = _users[i % 10].Id,
                Date = DateTime.Now.AddDays(-100 + i),
                Steps = 1000
            };
            _daysOfWalk.Add(dayOfWalk);
        }
        _modelBuilder.Entity<DayOfWalk>().HasData(_daysOfWalk);
    }
    
    private void GenerateArticles()
    {
        for (var i = 0; i < 10; i++)
        {
            var guid = Guid.NewGuid();
            var article = new Article
            {
                Id = guid,
                Title = $"Article {i}",
                Description = $"Content {i}",
                IllustrationPath = _articleImages[i % 3],
                StartDate = DateTime.Now,
                Published = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _articles.Add(article);
        }
        _modelBuilder.Entity<Article>().HasData(_articles);
    }
    
    private void GenerateBadges()
    {
        for (var i = 0; i < 10; i++)
        {
            var guid = Guid.NewGuid();
            var badge = new Badge
            {
                Id = guid,
                Title = $"Badge {i}",
                Description = $"Content {i}",
                IconPath = _badgeImages[i % 3],
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _badges.Add(badge);
        }
        _modelBuilder.Entity<Badge>().HasData(_badges);
    }
    
    private void GenerateChallenges()
    {
        for (var i = 0; i < 10; i++)
        {
            var guid = Guid.NewGuid();
            var challenge = new Challenge
            {
                Id = guid,
                Title = $"Challenge {i}",
                Description = $"Content {i}",
                BadgeId = _badges[i % 10].Id,
                IsGlobal = i % 2 == 0,
                Objective = new Random().Next(1000, 100000),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _challenges.Add(challenge);
        }
        _modelBuilder.Entity<Challenge>().HasData(_challenges);
    }

    private void GenerateBadgesToUser()
    {
        for (var i = 0; i < 10; i++)
        {
            var badgeToUser = new BadgesToUser()
            {
                BadgeId = _badges[i % 10].Id,
                UserId = _users[i % 10].Id,
                ObtainedAt = DateTime.Now
            };
            _badgesToUsers.Add(badgeToUser);
        }
        _modelBuilder.Entity<BadgesToUser>().HasData(_badgesToUsers);
    }
    
    public void Seed()
    {
        GenerateUsers();
        GenerateBadges();
        GenerateChallenges();
        GenerateArticles();
        GenerateDaysOfWalk();
        GenerateBadgesToUser();
    }
    
    #endregion
}