using Microsoft.Extensions.DependencyInjection;
using Ved.Time.Abstractions;

namespace Ved.Time.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddClock(this IServiceCollection services)
    {
        services.AddSingleton<IClock, Clock>();
    } 
}