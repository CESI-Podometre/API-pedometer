using Microsoft.Extensions.Options;
using StarFitApi.Config.Swagger;
using StarFitApi.Services.ArticleServices;
using StarFitApi.Services.BadgeServices;
using StarFitApi.Services.ChallengeServices;
using StarFitApi.Services.DayOfWalkServices;
using StarFitApi.Services.FileServices;
using StarFitApi.Services.UserServices;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace StarFitApi;

public static class DependencyInjections
{
    public static void AddInjections(this IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
        services.AddScoped<IFileService, FileService>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<IChallengeService, ChallengeService>();
        services.AddScoped<IDayOfWalkService, DayOfWalkService>();
        services.AddScoped<IBadgeService, BadgeService>();
    }
}