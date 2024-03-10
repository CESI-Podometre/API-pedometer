using Microsoft.Extensions.Options;
using StarFitApi.Config.Swagger;
using StarFitApi.Models.Database;
using StarFitApi.Services.ChallengeServices;
using StarFitApi.Services.DayOfWalkServices;
using StarFitApi.Services.TrophyServices;
using StarFitApi.Services.UserServices;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace StarFitApi;

public static class DependencyInjections
{
    public static void AddInjections(this IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IChallengeService, ChallengeService>();
        services.AddScoped<IDayOfWalkService, DayOfWalkService>();
        services.AddScoped<ITrophyService, TrophyService>();
    }
}